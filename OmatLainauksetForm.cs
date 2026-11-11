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
    public partial class OmatLainauksetForm : Form
    {
        MySqlConnection connection;
        string _kayttajatunnus;

        public OmatLainauksetForm(MySqlConnection connection, string kayttajatunnus)
        {
            InitializeComponent();
            this.connection = connection;
            _kayttajatunnus = kayttajatunnus;
        }

        private void btnHaeLainat_Click(object sender, EventArgs e)
        {
            //kysely joka kertoo kirjautuneen asiakkaan lainassa olevat kirjat 
            try
            {   
                string kysely;
                //MessageBox.Show("Etsitään tunnuksella :" + _kayttajatunnus);
                {
                    kysely = @"SELECT nide, nimi, palpvm
                            FROM kokoelma, kirja, asiakas, lainausrivi, lainaus
                            WHERE tunnus = lainaaja AND
                            kirjatun = kirjatunnus AND 
                            koktun = nide AND
                            lainanum = lainanumero AND
                            palautettu IS NULL AND
	                        tunnus = @tunnus"; //tunnus haetaan muuttujasta
                }

                dataGridView1.Rows.Clear();

                using (MySqlCommand cmd = new MySqlCommand(kysely, connection))
                {
                    //kerrotaan mitä @tunnus tarkoittaa riville 41
                    cmd.Parameters.AddWithValue("@tunnus", _kayttajatunnus);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                false,
                                reader["nide"],
                                reader["nimi"],
                                reader["palpvm"]
                                );
                        }
                    }
                }
                //tarkistetaan rivimäärä
                if (dataGridView1.Rows.Count == 0)
                {
                    MessageBox.Show("Ei lainauksia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPalauta_Click(object sender, EventArgs e)
        {
            // Pakotetaan mahdollinen käynnissä oleva muokkaus päätökseen ettei ohjelma lainaa kaikkia kirjoja
            dataGridView1.EndEdit();

            //määritellään lainaaja
            string lainaaja = _kayttajatunnus;

            //palautuspäivämäärä
            DateTime tanaan = DateTime.Today;

            //tarkistetaan, että ainakin yksi kirja on valittu
            if (dataGridView1.Rows.Count == 0 ||
                (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("Valitse kirja(t) jotka haluat palauttaa");
                return;
            }

            //alustetaan transaktio palautusta varten
            MySqlTransaction transaktio = null;

            try
            {
                transaktio = connection.BeginTransaction();

                // Käydään läpi kaikki palautettavien listan rivit
                foreach (DataGridViewRow rivi in dataGridView1.Rows)
                {
                    // Ohitetaan mahdollinen tyhjä "uusi rivi"
                    if (rivi.IsNewRow) continue;

                    //Haetaan "valitse" sarakkeen arvo ja muutetaan booleaniksi
                    bool onkoValittu = false;
                    if (rivi.Cells["valitse"].Value != null)
                    {
                        onkoValittu = (bool)rivi.Cells["valitse"].Value;
                    }

                    if(!onkoValittu)
                        { continue; }

                    var nideValue = rivi.Cells["nide"].Value;
                    if (nideValue == null) continue;

                    // Haetaan riviltä nide (yksilöivä tieto)
                    string nide = rivi.Cells["nide"].Value.ToString();

                    //kysely kokoelma-tauluun
                    string paivitaKokoelma = @"UPDATE Kokoelma
                                              SET lainassa = 0
                                              WHERE nide = @nide";

                    //luodaan komento ja suoritetaan kysely
                    using (MySqlCommand cmdpaivitaKokoelma = new MySqlCommand(paivitaKokoelma, connection, transaktio))
                    {
                        cmdpaivitaKokoelma.Parameters.AddWithValue("@nide", nide);
                        cmdpaivitaKokoelma.ExecuteNonQuery();
                    }

                    //päivitetään lainausrivi-taulu
                    string paivitaLainausrivi = @"UPDATE Lainausrivi
                                                   SET palautettu = @tanaan 
                                                   WHERE koktun = @nide AND palautettu IS NULL";

                    //luodaan komento ja suoritetaan 
                    using (MySqlCommand cmdpaivitaLainausrivi = new MySqlCommand(paivitaLainausrivi, connection, transaktio))
                    {
                        cmdpaivitaLainausrivi.Parameters.AddWithValue("@tanaan", tanaan);
                        cmdpaivitaLainausrivi.Parameters.AddWithValue("@nide", nide);
                        cmdpaivitaLainausrivi.ExecuteNonQuery();
                    }
                }

                // Vahvistetaan kaikki muutokset tietokantaan
                transaktio.Commit();

                MessageBox.Show("Palautus tallennettu!");

                // Tyhjennetään lainattavien lista käyttöliittymästä
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                // Virhetilanteessa perutaan kaikki tehdyt muutokset
                if (transaktio != null)
                {
                    // Jos jotain meni väärin, perutaan kaikki muutokset
                    transaktio.Rollback();
                }
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan. 
            //Määritykset tehty properties valikossa
        }
    }
}

