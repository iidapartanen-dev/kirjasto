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
    public partial class YhteystiedotForm : Form
    {
        MySqlConnection connection;
        string _kayttajatunnus;

        public YhteystiedotForm(MySqlConnection connection, string kayttajatunnus)
        {
            InitializeComponent();
            this.connection = connection;
            _kayttajatunnus = kayttajatunnus;

            // Kutsutaan metodia, joka hakee tiedot heti
            HaeNykyisetTiedot();
        }

        private void HaeNykyisetTiedot()
        {
            //Kysely, joka hakee käyttäjän tiedot tietokannasta sillä tunnuksella, jolla ollaan kirjauduttu
            try
            {
                string kysely = $"SELECT enimi, snimi, koso, pno, ptp, puh, email FROM asiakas WHERE tunnus = @tunnus";

                using (MySqlCommand cmd = new MySqlCommand(kysely, connection))
                {
                    //Kerrotaan tunnus, jota käytetään
                    cmd.Parameters.AddWithValue("@tunnus", _kayttajatunnus);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //täytetään tekstit tietokannasta löytyvillä tiedoilla
                            //käyttäjä näkee kerralla kaikki tiedot paitsi salasanan jota ei voi vaihtaa

                            txtEnimi.Text = reader["enimi"].ToString();
                            txtSnimi.Text = reader["snimi"].ToString();
                            txtKoso.Text = reader["koso"].ToString();
                            txtPno.Text = reader["pno"].ToString();
                            txtPtp.Text = reader["ptp"].ToString();
                            txtPuh.Text = reader["puh"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tietojen haku epäonnistui: " + ex.Message);
            }
        }

        private void btnPaivita_Click(object sender, EventArgs e)
        {
            //Alkuun tarkistus, että kaikki kentät on täytettynä ja mikään ei jää tyhjäksi
            TextBox[] kentat = {txtEnimi, txtSnimi, txtKoso, txtPno, txtPtp, txtPuh, txtEmail};

            foreach (TextBox tb in kentat)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Kaikki kentät ovat pakollisia! Täytä puuttuvat tiedot");
                    tb.Focus(); //siirtää kursorin tyhjään kohtaan
                    return; //Keskeyttää metodin suorituksen
                }
            }

            //Päivitetään kaikki asiakkaan tiedot vaikka hän ei kaikkea muuttaisi
            //Koska muut kentät sisälsivät jo valmiiksi vanhat tiedot, ne "päivittyvät" samoiksi arvoiksi kuin ennenkin

            string paivitys = @"UPDATE asiakas SET enimi = @enimi,
                                snimi = @snimi, 
                                koso = @koso, 
                                pno = @pno, 
                                ptp = @ptp, 
                                puh = @puh, 
                                email = @email 
                                WHERE tunnus = @tunnus";

            try
            {
                using (MySqlCommand cmd2 = new MySqlCommand(paivitys, connection))
                {
                    cmd2.Parameters.AddWithValue("@enimi", txtEnimi.Text);
                    cmd2.Parameters.AddWithValue("@snimi", txtSnimi.Text);
                    cmd2.Parameters.AddWithValue("@koso", txtKoso.Text);
                    cmd2.Parameters.AddWithValue("@pno", txtPno.Text);
                    cmd2.Parameters.AddWithValue("@ptp", txtPtp.Text);
                    cmd2.Parameters.AddWithValue("@puh", txtPuh.Text);
                    cmd2.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd2.Parameters.AddWithValue("@tunnus", _kayttajatunnus);

                    int rivit = cmd2.ExecuteNonQuery();

                    if (rivit > 0)
                        MessageBox.Show("Yhteystiedot päivitetty!");
                    else
                        MessageBox.Show("Päivitys epäonnistui.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe: " + ex.Message);
            }
        }
    }
}
