using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kirjasto
{
    using MySql.Data.MySqlClient;

    public partial class khForm : Form
    {
        MySqlConnection connection;
        string _kayttajatunnus;

        public khForm(MySqlConnection connection, string kayttajatunnus)
        {
            InitializeComponent();
            this.connection = connection;
            _kayttajatunnus = kayttajatunnus;
        }

        private void KhUusiAsiakas_Click(object sender, EventArgs e)
        {
            // Tässä luodaan uusi form jossa voidaan luoda uusi asiakas
            UusiAsiakasForm form = new UusiAsiakasForm(connection, _kayttajatunnus);
            form.Show();
        }

        private void khForm_Load(object sender, EventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan
        }

        private void khUusiKirja_Click(object sender, EventArgs e)
        {
            //Luodaan uusi form uuden kirjan lisäämiseen
            UusiKirjaForm form = new UusiKirjaForm(connection, _kayttajatunnus);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Luodaan uusi form jossa lisätään kirjailijoita, tekijöitä ja luokituksia
            PäivitäTietoja form = new PäivitäTietoja(connection, _kayttajatunnus);
            form.Show();
        }

        private void KhHaeKirja_Click(object sender, EventArgs e)
        {
            //Haetaan kirjat listboxiin kokoelma taulusta ja kirja taulusta
            //kokoelma taulu siksi, että saadaan listalle kaikki kirjastossa olevat kirjat

            string kirjat = $"SELECT nide, nimi, sivut, vuosi, kieli, muoto, luokka FROM kokoelma JOIN kirja WHERE kirjatun = kirjatunnus";

            using (MySqlCommand cmd = new MySqlCommand(kirjat, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string kirja = $"{reader["nide"]}" +
                            $" {reader["nimi"]} " +
                            $"{reader["sivut"]} " +
                            $"{reader["vuosi"]} " +
                            $"{reader["kieli"]} " +
                            $"{reader["muoto"]} " +
                            $"{reader["luokka"]}";
                        listBox1.Items.Add(kirja);
                    }
                    //piilotetaan hae button
                    KhHaeKirja.Visible = false;
                }
            }
        }

        private void KhValitse_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Valitse ensin kirja listalta!");
                return;
            }

            string teksti = listBox1.SelectedItem.ToString();
            string valittuKirja = teksti.Split(' ')[0];

            //kyselyllä selvitetään onko valittu kirja lainassa vai hyllyssä
            string kysely = $"SELECT count(*) FROM kokoelma WHERE nide = @id AND (lainassa = 0 OR lainassa IS NULL)";

            using (MySqlCommand cmd2 = new MySqlCommand(kysely, connection))
            {
                cmd2.Parameters.AddWithValue("@id", valittuKirja);

                try
                {
                    long vapaita = (long)cmd2.ExecuteScalar();

                    if (vapaita > 0)
                    {
                        MessageBox.Show("Kirja on hyllyssä lainattavissa");
                    }
                    else
                    {
                        MessageBox.Show("Kirja on lainassa");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe :" + ex.Message);
                }
            }
        }

        private void btnRaportit_Click(object sender, EventArgs e)
        {
            //Uusi form, jossa kirjastonhoitaja voi tarkistella raportteja
            Raportit form = new Raportit(connection, _kayttajatunnus);
            form.Show();
        }
    }
}
    
