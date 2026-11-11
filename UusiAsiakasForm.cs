
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace kirjasto
{
    public partial class UusiAsiakasForm : Form
    {
        MySqlConnection connection;
        string _kayttajatunnus;

        public UusiAsiakasForm(MySqlConnection connection, string kayttajatunnus) // vastaanottaa yhteyden
        {
            InitializeComponent();
            this.connection = connection;
            _kayttajatunnus = kayttajatunnus;
        }

        private void txtAsnum_Click(object sender, EventArgs e)
        {

            string uusiId = "";
            string kuluvaVuosi = DateTime.Now.Year.ToString().Substring(2);

            // Haetaan suurin tunnus tietokannasta
            string kysely = $"SELECT MAX(tunnus) AS SuurinId FROM Asiakas WHERE tunnus LIKE 'AS%{kuluvaVuosi}'";

            using (MySqlCommand cmd = new MySqlCommand(kysely, connection))
            {
                var tulos = cmd.ExecuteScalar()?.ToString();

                uusiId = LuoUusiTunnus(tulos);

                if (string.IsNullOrEmpty(uusiId))
                {
                    // Jos tietueita ei ole
                    uusiId = $"AS001{kuluvaVuosi}";
                }
            }

            // Kirjoitetaan tekstikenttään uusi asiakasnumero
            txtAsnum.Text = uusiId;
            label2.Visible = true;
        }

        private static string LuoUusiTunnus(string edellinenTunnus)
        {
            //Metodi jossa uusi tunnus luodaan
            string kuluvaVuosi = DateTime.Now.Year.ToString().Substring(2);

            if (!string.IsNullOrEmpty(edellinenTunnus))
            {
                string vuosiOsa = edellinenTunnus.Substring(5, 2);
                string numeroOsa = edellinenTunnus.Substring(2, 3);
                int numero;

                if (vuosiOsa == kuluvaVuosi)
                {
                    numero = int.Parse(numeroOsa) + 1;
                }
                else
                {
                    numero = 1;
                }
                return $"AS{numero.ToString("D3")}{kuluvaVuosi}";
            }
            else
            {
                return $"AS001{kuluvaVuosi}";
            }
        }

        private void Lisää_Click(object sender, EventArgs e)
        {
            //Alkuun tarkistus, että kaikki kentät on täytettynä ja mikään ei jää tyhjäksi
            TextBox[] kentat = { txtAsnum, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7,textBox8 };

            foreach (TextBox tb in kentat)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Kaikki kentät ovat pakollisia! Täytä puuttuvat tiedot");
                    tb.Focus(); //siirtää kursorin tyhjään kohtaan
                    return; //Keskeyttää metodin suorituksen
                }
            }

            //luodaan uusi asiakas
            string lisays = @"INSERT INTO Asiakas 
                            (tunnus, enimi, snimi, koso, pno, ptp, puh, email)
                            VALUES
                            (@tunnus, @enimi, @snimi, @koso, @pno, @ptp, @puh, @email)";

            //Määritetään suoritettava SQL-komento ja, mitä tietokantayhteyttä käytetään
            //Yhteys on määritelty rivillä 35
            MySqlCommand cmd = new MySqlCommand(lisays, connection);

            cmd.Parameters.AddWithValue("@tunnus", txtAsnum.Text);
            cmd.Parameters.AddWithValue("@enimi", textBox2.Text);
            cmd.Parameters.AddWithValue("@snimi", textBox3.Text);
            cmd.Parameters.AddWithValue("@koso", textBox4.Text);
            cmd.Parameters.AddWithValue("@pno", textBox5.Text);
            cmd.Parameters.AddWithValue("@ptp", textBox6.Text);
            cmd.Parameters.AddWithValue("@puh", textBox7.Text);
            cmd.Parameters.AddWithValue("@email", textBox8.Text);

            //Suoritetaan kysely (eli INSERT INTO -lause)
            cmd.ExecuteNonQuery();

            //valmistellaan tiedostoon kirjoitettava rivi
            //käytetään suoraan muuttujia ja tekstikenttiä

            string uusiRivi = $"{txtAsnum.Text};{txtSalasana.Text};asiakas";

            try
            {
                using (StreamWriter kirjoittaja = new StreamWriter("users.txt", true))
                {

                    kirjoittaja.WriteLine(uusiRivi);
                    //using rakenne sulkee tiedoston automaattisesti, ei tarvita .Close()
                }
                MessageBox.Show("Uusi asiakas tallennettu tietokantaan ja tunnukset luotu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tiedostoon kirjoittaminen epäonnistui: " + ex.Message);
            }

            //Tyhjennetään tekstikentät
            txtAsnum.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            txtSalasana.Clear();
        }

        //vaikka tiedosto on tallennettu solution exploreriin, niin alkuperäinen ja päivittyvä löytyy projektin debug-kansiosta
        //jos tiedoston avaa solution explorerin kautta, näkee sen verison mikä oli ennen ohjelman käynnistämistä
        //tiedoston properties valikossa on määritelty "Copy to Output Directory: Copy if newer"
        //tämä tarkoittaa sitä, että jos tiedostoa muokataan solution explorerissa, se ylikirjoittaa 
        //Debug-kansion kansion version, seuraavalla kerralla kun ohjelma käynnistetään







        private void txtAsnum_TextChanged(object sender, EventArgs e)
        {
            //Vahinko klikkaus, ei vaikuta ohjelman toimintaan
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Vahinko klikkaus, ei vaikuta ohjelman toimintaan
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Vahinko klikkaus, ei vaikuta ohjelman toimintaan
        }
    }


}

    
