namespace kirjasto
{
    using System;
    using System.Data;
    using System.Windows.Forms;
    using MySql.Data.MySqlClient;

    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Uusi form asiakkaan n‰kym‰‰n
            // tehty projektin alkuvaiheessa, s‰ilytet‰‰n testaukseen
            asiakasForm form = new asiakasForm(connection, "Testik‰ytt‰j‰");
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Uusi form kirjastonhoitajan n‰kym‰‰n
            //tehty projektin alkuvaiheessa, s‰ilytet‰‰n testaukseen
            khForm form = new khForm(connection, "Testik‰ytt‰j‰");
            form.Show();
        }

        private void LuoYhteys_Click(object sender, EventArgs e)
        {
            //Alkuun tarkistus, ett‰ kaikki kent‰t on t‰ytettyn‰ ja mik‰‰n ei j‰‰ tyhj‰ksi
            TextBox[] kentat = { textBox1, textBox2, textBox3, textBox4 };

            foreach (TextBox tb in kentat)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Kaikki kent‰t ovat pakollisia! T‰yt‰ puuttuvat tiedot");
                    tb.Focus(); //siirt‰‰ kursorin tyhj‰‰n kohtaan
                    return; //Keskeytt‰‰ metodin suorituksen
                }
            }
            // Luodaan yhteys tietokantaan
            string connectionString = "SERVER=" + textBox1.Text + ";PORT=3306;DATABASE=" + textBox2.Text + ";UID=" + textBox3.Text + ";PASSWORD=" + textBox4.Text;

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
                MessageBox.Show("Yhteyden muodostus onnistui!\n Jatka kirjautumalla sis‰‰n j‰rjestelm‰‰n");
            }
            catch
            {
                MessageBox.Show("Yhteyden muodostaminen ei onnistunut, yrit‰ uudelleen");
            }
        }

        private void katkaise_Click(object sender, EventArgs e)
        {
            // yhteyden katkaiseminen
            try
            {
                connection.Close();
                MessageBox.Show("Yhteyden katkaiseminen onnistui");
            }
            catch
            {
                MessageBox.Show("Yhteyden katkaiseminen ei onnistunut");
            }
        }

        private void btnKirjaudu_Click(object sender, EventArgs e)
        {
            //Luetaan syˆtteet
            string syotettyTunnus = txtTunnus.Text;
            string syotettySalasana = txtSalasana.Text;

            //tarkistetaan, ettei ole tyhji‰ kentti‰
            if (string.IsNullOrWhiteSpace(syotettyTunnus) || string.IsNullOrWhiteSpace(syotettySalasana))
            {
                MessageBox.Show("Kirjoita sek‰ k‰ytt‰j‰tunnus, ett‰ salasana");
                return;
            }

            // Kutsutaan logiikkaa kerran ja tallennetaan tulos muuttujaan
            string rooli = TarkistaKayttajaJaRooli(syotettyTunnus, syotettySalasana);

            //tarkistetaan, ettei rooli ole null
            if (rooli != null)
            {
                MessageBox.Show("Kirjautuminen onnistui! \n Tervetuloa!");

                if (rooli == "asiakas")
                {
                    asiakasForm af = new asiakasForm(connection, syotettyTunnus);
                    af.Show();
                }
                else if (rooli == "kh")
                {
                    khForm af = new khForm(connection, syotettyTunnus);
                    af.Show();
                }
            }
            else
            {
                MessageBox.Show("V‰‰r‰ k‰ytt‰j‰tunnus tai salasana, yrit‰ uudelleen!");
            }
        }
        private string TarkistaKayttajaJaRooli(string tunnus, string salasana)
        {
            string tiedostoPolku = "users.txt";
            if (!File.Exists(tiedostoPolku)) return null;

            var rivit = File.ReadAllLines(tiedostoPolku);

            // DEBUG: Kuinka monta rivi‰ tiedostosta lˆytyi?
            //MessageBox.Show("Rivej‰ lˆytyi: " + rivit.Length);

            foreach (var rivi in rivit)
            {
                var osat = rivi.Split(';');
                if (osat.Length == 3) //nyt riveill‰ on kolme osaa: k‰ytt‰j‰tunnus,salasana ja rooli
                {
                    string tiedostoTunnus = osat[0].Trim();
                    string tiedostoSalasana = osat[1].Trim();
                    string rooli = osat[2].Trim();

                    if (tiedostoTunnus == tunnus && tiedostoSalasana == salasana)
                    {
                        return rooli; //palautetaan rooli, asiakas tai kirjastonhoitaja
                    }
                }
            }
            return null;

        }

        private void txtSalasana_TextChanged(object sender, EventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Vahinkonapsautus, ei vaikuta ohjelman toimintaan
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //Vahinkonapsautus ei vaikuta ohjelman toimintaan
        }
    }
}
