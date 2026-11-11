using MySql.Data.MySqlClient;
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
    public partial class Raportit : Form
    {
        MySqlConnection connection;
        string _kayttajatunnus;

        public Raportit(MySqlConnection connection, string kayttajatunnus)
        {
            InitializeComponent();
            this.connection = connection;
            _kayttajatunnus = kayttajatunnus;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Vahinkoklikkaus, ei vaikuta ohjelman toimintaan
        }

        private void cmbRaportit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Designerissa Items kohtaan määritelty seuraavat kyselyt joista käyttäjä voi valita:
            //Suosituimmat kirjat
            //Ei koskaan lainattu
            //Asiakkaat ja lainojen määrä
            //Asiakkaat jotka eivät ole lainanneet
            //Myöhässä olevat kirjat

            string valinta = cmbRaportit.SelectedItem.ToString();
            string kysely = "";

            switch (valinta)
            {
                case "Suosituimmat kirjat":
                    kysely = @"SELECT nimi, COUNT(lainanum) AS Lainaukset
                       FROM kirja
                       JOIN kokoelma ON kirjatunnus = kirjatun
                       JOIN lainausrivi ON nide = koktun
                       GROUP BY nimi
                       ORDER BY Lainaukset DESC";

                    break;

                case "Ei koskaan lainattu":
                    kysely = @"SELECT nimi 
                               FROM kirja 
                               LEFT JOIN kokoelma ON kirjatunnus = kirjatun 
                               LEFT JOIN lainausrivi ON nide = koktun 
                               WHERE koktun IS NULL";
                    break;

                case "Asiakkaat ja lainojen määrä":
                    kysely = @"SELECT tunnus, enimi, snimi, COUNT(lainanumero) AS Lainaukset
                               FROM asiakas 
                               JOIN lainaus ON tunnus = lainaaja 
                               GROUP BY tunnus, enimi, snimi";
                    break;

                case "Asiakkaat jotka eivät ole lainanneet":
                    kysely = @"SELECT enimi, snimi 
                               FROM asiakas 
                               LEFT JOIN lainaus ON tunnus = lainaaja 
                               WHERE lainanumero IS NULL";
                    break;

                case "Myöhässä olevat kirjat":
                    kysely = @"SELECT nimi, lainaaja
                                FROM kirja  
                                JOIN kokoelma ON kirjatunnus = kirjatun
                                JOIN lainausrivi ON nide = koktun
                                JOIN lainaus ON lainanumero = lainanum
                                WHERE palautettu IS NULL AND
                                palpvm < CURRENT_DATE ";
                    break;

                default:
                    //Tämä suoritetaan jos valinta ei täsmää mihinkään ylläolevista
                    return;

            }
            if (!string.IsNullOrEmpty(kysely))
            {
                //Kutsutaan raportin luku metodi
                PaivitaRaporttiTaulukko(kysely);
            }
        }
        private void PaivitaRaporttiTaulukko(string sql)
        {
            try
            {
                // Luodaan adapteri, joka suorittaa kyselyn
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, connection);

                //Luodaan muistiin tyhjä "virtuaalinen taulukko" (DataTable)
                DataTable dt = new DataTable();

                //Täytetään virtuaalinen taulukko tietokannasta tulevalla datalla
                adapter.Fill(dt);

                //Kytketään taulukko näkyviin DataGridViewiin
                dataGridView1.DataSource = dt; // Tämä täyttää taulukon automaattisesti!

                //säädetään sarakkeiden leveys automaattisesti tekstin mukaan
                dataGridView1.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Raportin haku epäonnistui: " + ex.Message);
            }
        }
    }
}
        
    

