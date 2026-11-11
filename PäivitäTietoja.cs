using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kirjasto
{
    public partial class PäivitäTietoja : Form
    {
        MySqlConnection connection;
        string _kayttajatunnus;

        public PäivitäTietoja(MySqlConnection connection, string kayttajatunnus)
        {
            InitializeComponent();
            this.connection = connection;
            _kayttajatunnus = kayttajatunnus;
        }

        private void btnLisääTekijä_Click(object sender, EventArgs e)
        {
            //Alkuun tarkistus, että kaikki kentät on täytettynä ja mikään ei jää tyhjäksi
            TextBox[] kentat = { isbn, kirtun };

            foreach (TextBox tb in kentat)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Molemmat kentät ovat pakollisia, täytä puuttuvat tiedot");
                    tb.Focus(); //siirtää kursorin tyhjään kohtaan
                    return; //Keskeyttää metodin suorituksen
                }
            }
            //Lisätään uusi tekijä tietokantaan
            string uusiTekijä = @"INSERT INTO tekijä
                                (ktun, kirtun)
                                 VALUES
                                 (@isbn, @kirtun)";

            //yhteys tietokantaan
            MySqlCommand cmd = new MySqlCommand(uusiTekijä, connection);

            //Lisätään tekstit textboxeista
            cmd.Parameters.AddWithValue("@isbn", isbn.Text);
            cmd.Parameters.AddWithValue("@kirtun", kirtun.Text);

            //suoritetaan INSERT INTO
            cmd.ExecuteNonQuery();

            //infotaan käyttäjää
            MessageBox.Show("Uusi tekijä lisätty!");

            //tyhjennetään textboxit
            isbn.Clear();
            kirtun.Clear();
        }

        private void btnLisääKirjailija_Click(object sender, EventArgs e)
        {
            //LISÄÄ TARKISTUS ONKO KIRJAILIJA JO TIETOKANNASSA KIRJAN TEKIJÄNÄ
            //Alkuun tarkistus, että kaikki kentät on täytettynä ja mikään ei jää tyhjäksi
            TextBox[] kentat = { tunnus, enimi, snimi };

            foreach (TextBox tb in kentat)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Kaikki kentät ovat pakollisia! Täytä puuttuvat tiedot");
                    tb.Focus(); //siirtää kursorin tyhjään kohtaan
                    return; //Keskeyttää metodin suorituksen
                }
            }

            //Lisätään uusi kirjailija
            string uusiKirjailija = @"INSERT INTO kirjailija
                                     (tunnus, enimi, snimi)
                                     VALUES
                                     (@tunnus, @enimi, @snimi)";

            MySqlCommand cmd2 = new MySqlCommand(uusiKirjailija, connection);

            cmd2.Parameters.AddWithValue("@tunnus", tunnus.Text);
            cmd2.Parameters.AddWithValue("@enimi", enimi.Text);
            cmd2.Parameters.AddWithValue("@snimi", snimi.Text);

            cmd2.ExecuteNonQuery();

            MessageBox.Show("Uusi kirjailija lisätty!");

            tunnus.Clear();
            enimi.Clear();
            snimi.Clear();
        }

        private void btnLisääLuokka_Click(object sender, EventArgs e)
        {
            //Alkuun tarkistus, että kaikki kentät on täytettynä ja mikään ei jää tyhjäksi
            TextBox[] kentat = { ltun, kuvaus };

            foreach (TextBox tb in kentat)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Kaikki kentät ovat pakollisia! Täytä puuttuvat tiedot");
                    tb.Focus(); //siirtää kursorin tyhjään kohtaan
                    return; //Keskeyttää metodin suorituksen
                }
            }

            //Lisätään uusi luokka
            string uusiLuokka = @"INSERT INTO luokitus
                                  (ltun, kuvaus)
                                  VALUES
                                 (@ltun, @kuvaus)";

            MySqlCommand cmd3 = new MySqlCommand(uusiLuokka, connection);

            cmd3.Parameters.AddWithValue("@ltun", ltun.Text);
            cmd3.Parameters.AddWithValue("@kuvaus", kuvaus.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("Uusi luokka lisätty!");

            ltun.Clear();
            kuvaus.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Vahinko klikkaus otsikkoon, ei vaikuta ohjelman toimintaan
        }

        private void label10_Click(object sender, EventArgs e)
        {
            //Vahinko klikkaus otsikkoon, ei vaikuta ohjelman toimintaan
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Vahinkoklikkaus comboboxiin, ei vaikuta ohjelman toimintaan
        }

        private void PäivitäTietoja_Load(object sender, EventArgs e)
        {
            string haeKirjailijat = @"SELECT * FROM kirjailija";
            using (MySqlCommand cmd4 = new MySqlCommand(haeKirjailijat, connection))
            {
                using (MySqlDataReader reader = cmd4.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string kirjailijat = $"{reader["tunnus"]} {reader["enimi"]} {reader["snimi"]}";
                        comboBox1.Items.Add(kirjailijat);
                    }
                }
                //Comboboxiin ensimmäinen kirjailija
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
