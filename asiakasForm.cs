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
    public partial class asiakasForm : Form
    {
        MySqlConnection connection = new MySqlConnection();
        string _kayttajatunnus;

        public asiakasForm(MySqlConnection connection, string kayttajatunnus)
        {
            InitializeComponent();
            this.connection = connection;
            _kayttajatunnus = kayttajatunnus;
        }

        private void AsHae_Click(object sender, EventArgs e)
        {
            //Haetaan lainattavissa olevat kirjat
            try
            {
                string haku = txtHae.Text.Trim();
                string kysely;

                if (haku == "")
                {   //Kysely hakee kaikki vapaana olevat kirjat
                    kysely = @"SELECT nide, nimi, kieli, luokka
                              FROM kokoelma
                              JOIN kirja
                              ON kirjatun = kirjatunnus
                              WHERE lainassa = 0 OR lainassa IS NULL";
                }
                else
                {   //Kysely hakee käyttäjän hakusanoja vastaavat lainassa olevat kirjat
                    kysely = @"SELECT nide, nimi, kieli, luokka
                             FROM kokoelma
                             JOIN kirja
                             ON kirjatun = kirjatunnus
                             WHERE (lainassa = 0 OR lainassa IS NULL)
                             AND (nimi LIKE @haku OR kirjatunnus LIKE @haku)";
                }

                dataGridView1.Rows.Clear();

                using (MySqlCommand cmd = new MySqlCommand(kysely, connection))
                {
                    if (haku != "")
                    {
                        cmd.Parameters.AddWithValue("@haku", "%" + haku + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                false,
                                reader["nide"],
                                reader["nimi"],
                                reader["kieli"],
                                reader["luokka"]
                                );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void asiakasForm_Load(object sender, EventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan
        }

        private void txtHae_TextChanged(object sender, EventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan
        }


        private void btnLainaa_Click(object sender, EventArgs e)
        {
            // Pakotetaan mahdollinen käynnissä oleva muokkaus päätökseen ettei ohjelma lainaa kaikkia kirjoja
            dataGridView1.EndEdit();

            // Kutsutaan apumetodia juoksevan lainanumeron hakemiseksi
            string lainanumero = HaeUusiLainanumero();

            //Haetaan lainaaja suoraan muuttujasta
            string lainaaja = _kayttajatunnus;

            //päivämäärä
            DateTime tanaan = DateTime.Today;

            //laina-aika
            DateTime palautusPvm = tanaan.AddDays(14);

            //luodaan lista tulostusta varten
            List<string> lainatutKirjat = new List<string>();


            //tarkistetaan, että ainakin yksi kirja on valittu
            if (dataGridView1.Rows.Count == 0 ||
                (dataGridView1.Rows.Count == 1 && dataGridView1.Rows[0].IsNewRow))
            {
                MessageBox.Show("Valitse kirja(t) jotka haluat lainata");
                return;
            }
            //alustetaan transaktio
            MySqlTransaction transaktio = null;

            try
            {
                transaktio = connection.BeginTransaction();

                //kysely lainaus-tauluun
                string kyselyLainaus = @"INSERT INTO lainaus (lainanumero, lainaaja, pvm)
                                        VALUES (@lainanumero, @lainaaja, @pvm)";
                //suoritetaan lainauksen lisäys
                using (MySqlCommand cmdLainaus = new MySqlCommand(kyselyLainaus, connection, transaktio))
                {
                    cmdLainaus.Parameters.AddWithValue("@lainanumero", lainanumero);
                    cmdLainaus.Parameters.AddWithValue("@lainaaja", _kayttajatunnus);
                    cmdLainaus.Parameters.AddWithValue("@pvm", tanaan);

                    cmdLainaus.ExecuteNonQuery();
                }
                //käydään läpi lainattavien rivit
                foreach (DataGridViewRow rivi in dataGridView1.Rows)
                {
                    //ohitetaan tyhjät rivit
                    if (rivi.IsNewRow) continue;

                    // Haetaan CheckBoxin arvo 
                    object cellValue = rivi.Cells[0].Value;
                    bool isSelected = cellValue != null && Convert.ToBoolean(cellValue);

                    if (isSelected)
                    {
                        //haetaan riviltä nide 
                        string nide = rivi.Cells["nide"].Value.ToString();
                        //otetaan kirjan nimi talteen tulostusta varten
                        string kirjanNimi = rivi.Cells["nimi"].Value.ToString();

                        //kysely lainausrivin lisäämiseksi lainausrivi-tauluun
                        string kyselyLainausrivi = @"INSERT INTO lainausrivi (lainanum, koktun, palpvm) VALUES (@lainanum, @koktun,@palpvm)";

                        //suoritetaan lainausrivin lisäys
                        using (MySqlCommand cmdLainausrivi = new MySqlCommand(kyselyLainausrivi, connection, transaktio))
                        {
                            cmdLainausrivi.Parameters.AddWithValue("@lainanum", lainanumero);
                            cmdLainausrivi.Parameters.AddWithValue("@koktun", nide);
                            cmdLainausrivi.Parameters.AddWithValue("@palpvm", palautusPvm);

                            cmdLainausrivi.ExecuteNonQuery();
                        }
                        //kokoelma tauluun määritellään päivitys
                        string kyselyPaivitaKokoelma = @"UPDATE kokoelma SET lainassa = 1 WHERE nide = @nide";

                        //luodaan komento ja suoritetaan
                        using (MySqlCommand cmdPaivitaKokoelma = new MySqlCommand(kyselyPaivitaKokoelma, connection, transaktio))
                        {
                            cmdPaivitaKokoelma.Parameters.AddWithValue("@nide", nide);
                            cmdPaivitaKokoelma.ExecuteNonQuery();
                        }
                        //lisätään valitut kirjat listalle
                        lainatutKirjat.Add("- " + kirjanNimi);
                    }
                }

                //vahvistetaan muutokset tietokantaan
                transaktio.Commit();

                //muodostetaan loppuviesti
                string viesti = $"Lainaus tallennettu!\n\nLainan numero: {lainanumero}\nPalautuspäivä: {palautusPvm.ToShortDateString()}\n\nLainatut kirjat:\n" + string.Join("\n", lainatutKirjat);

                MessageBox.Show(viesti, "Kiitos lainauksesta!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //tyhjennetään lainattavat
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


        private void button2_Click(object sender, EventArgs e)
        {
            //avataan uusi form, jossa voi tarkistella omia lainauksia
            //Form luotu projektin alkuvaiheessa, säilytetään testinä
            OmatLainauksetForm form = new OmatLainauksetForm(connection, _kayttajatunnus);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //avataan uusi form, jossa asikas voi päivittää yhteystietonsa
            YhteystiedotForm form = new YhteystiedotForm(connection, _kayttajatunnus);
            form.Show();
        }

        private string HaeUusiLainanumero()
        {
            //Haetaan suurin lainanumero tietokannasta
            string kysely = "SELECT MAX(lainanumero) FROM lainaus";

            //TÄMÄN OSUDEN LOGIIKAN VOISI KORJATA....
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(kysely, connection))
                {
                    object tulos = cmd.ExecuteScalar();

                    if (tulos == null || tulos == DBNull.Value)
                    {
                        // Jos tietokanta on tyhjä, aloitetaan tästä
                        return "LN2600001"; 
                    }

                    string viimeisin = tulos.ToString();

                    // Otetaan numeron osa (LN-tekstin jälkeen alkaen indeksistä 2)
                    string numeroOsa = viimeisin.Substring(2); // Poistaa "LN"

                    // Muutetaan numeroksi, lisätään 1 ja muotoillaan takaisin LN-muotoon
                    if (long.TryParse(numeroOsa, out long luku))
                    {
                        luku++;
                        return "LN" + luku.ToString("D7"); // D7 varmistaa 7-numeroisen pituuden
                    }
                    return "LN2600001";
                }
            }
            catch
            {
                return "LN" + DateTime.Now.ToString("mmssfff"); // Varajärjestelmä virhetilanteessa
            }
        }
    }
}