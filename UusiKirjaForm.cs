using Google.Protobuf.Collections;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace kirjasto
{
    public partial class UusiKirjaForm : Form
    {
        MySqlConnection connection;
        string _kayttajatunnus;

        public UusiKirjaForm(MySqlConnection connection, string kayttajatunnus)
        {
            InitializeComponent();
            this.connection = connection;
            _kayttajatunnus = kayttajatunnus;
        }

        private void btnLisääKirja_Click(object sender, EventArgs e)
        {
            //Tarkistetaan ensin, että kaikki kentät on täytetty
            if (string.IsNullOrWhiteSpace(isbn.Text) || string.IsNullOrWhiteSpace(kirja.Text) ||
            string.IsNullOrWhiteSpace(sivut.Text) || string.IsNullOrWhiteSpace(vuosi.Text) ||
            string.IsNullOrWhiteSpace(kpl.Text) || string.IsNullOrWhiteSpace(muoto.Text))
            {
                MessageBox.Show("Täytä kaikki pakolliset kentät!");
                return; // Keskeytetään suoritus mikäli tietoja puuttuu
            }

            //Seuraavaksi tarkistetaan, että sivut,vuosi,kpl ja isbn on numeroita
            // TryParse yrittää muuttaa tekstin numeroksi. Jos epäonnistuu, se antaa 'false'.
            if (!int.TryParse(sivut.Text, out int sivutLuku) ||
                !int.TryParse(vuosi.Text, out int vuosiLuku) ||
                !int.TryParse(kpl.Text, out int maara) ||
                !long.TryParse(isbn.Text, out _)) // Tarkistetaan myös että ISBN on numero
            {
                MessageBox.Show("Sivumäärän, vuosiluvun, kappalemäärän ja ISBN-tunnuksen on oltava numeroita!");
                return;
            }

            //Lisätään uusi kirja tietokantaan
            string uusiKirja = @"INSERT INTO kirja
                                (kirjatunnus, nimi, sivut, vuosi, kieli, muoto, luokka)
                                VALUES
                                (@ISBN, @nimi, @sivut, @vuosi, @kieli, @muoto, @luokka)";

            MySqlCommand cmd = new MySqlCommand(uusiKirja, connection);

            cmd.Parameters.AddWithValue("@ISBN", isbn.Text);
            cmd.Parameters.AddWithValue("@nimi", kirja.Text);
            //sivumäärä ja vuosi muutetaan kokonaisluvuiksi
            cmd.Parameters.AddWithValue("@sivut", Convert.ToInt32(sivut.Text));
            cmd.Parameters.AddWithValue("@vuosi", Convert.ToInt32(vuosi.Text));
            cmd.Parameters.AddWithValue("@kieli", kieli.Text);
            cmd.Parameters.AddWithValue("@muoto", muoto.Text);
            cmd.Parameters.AddWithValue("@luokka", cmbLuokka.Text.Split(' ')[0]);

            //Suoritetaan INSERT INTO
            cmd.ExecuteNonQuery();

            //lisätään nidetunnus kokoelma-tauluun
            string uusiNide = @"INSERT INTO kokoelma
                            (nide, kirjatun)
                            VALUES
                            (@nide, @kirjatun)";

            MySqlCommand cmd2 = new MySqlCommand(uusiNide, connection);

            //Lisätään niteet tietokantaan
            for (int i = 1; i <= maara; i++)
            {
                cmd2.Parameters.Clear();
                cmd2.Parameters.AddWithValue("@nide", isbn.Text + i.ToString("D2"));
                cmd2.Parameters.AddWithValue("@kirjatun", isbn.Text);

                //Suoritetaan INSERT INTO
                cmd2.ExecuteNonQuery();
            }

            //Lisätään tekijä
            string uusiTekijä = @"INSERT INTO tekijä
                                (ktun, kirtun)
                                VALUES
                                (@ktun, @kirtun)";

            MySqlCommand cmd3 = new MySqlCommand(uusiTekijä, connection);

            cmd3.Parameters.AddWithValue("@ktun", isbn.Text);
            cmd3.Parameters.AddWithValue("@kirtun", cmbTekijä.Text.Split(' ')[0]);

            //Suoritetaan INSERT INTO
            cmd3.ExecuteNonQuery();

            // Hyödynnetään tekstikentän 'kirja' sisältöä ja muuttujaa 'maara'
            string onnistumisViesti = $"Uusi kirja '{kirja.Text}' on lisätty onnistuneesti!\n\nYhteensä {maara} nidettä lisätty.";

            MessageBox.Show(onnistumisViesti, "Tallennus onnistui", MessageBoxButtons.OK, MessageBoxIcon.Information);


            //Tyhjennetään kentät tallennuksen jälkeen
            isbn.Clear();
            kirja.Clear();
            sivut.Clear();
            vuosi.Clear();
            kpl.Clear();
            kieli.Clear();
            muoto.Clear();

            // Palautetaan ComboBoxit alkuasentoon
            if (cmbLuokka.Items.Count > 0) cmbLuokka.SelectedIndex = 0;
            if (cmbTekijä.Items.Count > 0) cmbTekijä.SelectedIndex = 0;

            isbn.Focus(); // Asetetaan kursori takaisin alkuun
        }

        private void btnHaeLuokat_Click(object sender, EventArgs e)
        {
            //Haetaan luokat comboboxiin
            string haeLuokka = $"SELECT ltun, kuvaus FROM luokitus";

            using (MySqlCommand cmd = new MySqlCommand(haeLuokka, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Tiedot = $"{reader["ltun"]} {reader["kuvaus"]}";
                        cmbLuokka.Items.Add(Tiedot);
                    }
                }
                //Comboboxiin ensimmäinen luokka teksteineen
                cmbLuokka.SelectedIndex = 0;
            }
        }

        private void btnHaeTekijä_Click(object sender, EventArgs e)
        {
            //Haetaan tekijät comboboxiin
            string haeKirjailija = $"SELECT tunnus, enimi, snimi FROM kirjailija";

            using (MySqlCommand cmd = new MySqlCommand(haeKirjailija, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string Kirjailija = $"{reader["tunnus"]} {reader["enimi"]} {reader["snimi"]}";
                        cmbTekijä.Items.Add(Kirjailija);
                    }
                }
                //Comboboxiin ensimmäinen tekijä
                cmbTekijä.SelectedIndex = 0;
            }
        }
    }
}
