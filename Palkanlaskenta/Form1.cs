using System.Runtime.CompilerServices;
using System.Security.Policy;

namespace Palkanlaskenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tallennetaan ja luetaan työntekijät tekstitiedostosta Työntekijät.txt
        private const string DataFilePath = "Tyontekijät.txt";

        // Tallennetaan palkkatiedot Palkkatiedot.txt teksti tiedostoon
        private const string PayDataFilePath = "Palkkatiedot.txt";


        // tehdään metodi millä järjestetään aakkosjärjestykseen
        private void JarjestaAakkosJarjestykseen()
        {
            // hae itemin multiboxista ja tallenna muuttujaan items
            var items = TyonTekijatComboBox.Items.Cast<string>().ToList();

            items.Sort(); // järjestä aakkosjärjestykseen

            TyonTekijatComboBox.Items.Clear(); // tyhjennä combobox 
            TyonTekijatComboBox.Items.AddRange(items.ToArray());// ja lisää itemit takaisin
        }


        // lataa työntekijä tiedot listasta multiboxiin
        private void LataaTyontekijat()
        {
            try
            {
                // tarkastetaan löytyykö tiedosto
                if (File.Exists(DataFilePath))
                {
                    var tyontekijat = File.ReadAllLines(DataFilePath);
                    TyonTekijatComboBox.Items.AddRange(tyontekijat);

                    JarjestaAakkosJarjestykseen(); // järjestä aakkosjärjestykseen

                }
                else
                {
                    // jos tiedostoa ei löydy lisätään mallikappale
                    TyonTekijatComboBox.Items.Add("Maija Mansikka");
                    MessageBox.Show("Tiedostoa ei löytynyt, jatketaan malli ihmisellä");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe tiedoston lukemisessa: {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // tehdään metodi mitä käytetään veroprosentin määrittämiseen, lisätään bruttopalkka
        private static double LaskeVeroprosentti(double bruttopalkka)
        {
            // määritetään veroprosentti bruttopalkan mukaan, käyttäen switch
            return bruttopalkka switch
            {
                > 7000 => 40.0, // if bruttopalkka => 7000, return 40% jne
                > 5000 => 30.0,
                > 3000 => 25.0,
                > 2000 => 19.0,
                > 1500 => 15.0,
                _ => 12.0
            };

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // varmistetaan tiedoston "työntekijät" luku Form1_Load
        private void Form1_Load(object sender, EventArgs e)
        {
            LataaTyontekijat();

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLaske_Click(object sender, EventArgs e)
        {
            try
            {
                // jos henkilöä ei ole valittu, ilmoita käyttäjälle
                if (TyonTekijatComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Valitse työntekijä.");
                    return;
                }

                // tallennetaan muuttujiin käyttäjän valinnat ja syötetyt arvot
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                string tyontekija = TyonTekijatComboBox.SelectedItem.ToString();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                int tyotunnit = int.Parse(txtTyotunnit.Text);
                double tuntipalkka = double.Parse(txtTuntipalkka.Text);

                // jos työtunnit on yli 40, lasketaan ylityötunnit
                double normaalitunnit = Math.Min(tyotunnit, 40); // normaalitunnit = max 40
                double ylityotunnit = Math.Max(0, tyotunnit - 40); // ylityotunnit = 40 ->

                // Tarkistetaan että syötetyt arvot ovat positiivisia
                if (tyotunnit < 0 || tuntipalkka < 0)
                {
                    MessageBox.Show("Tarkista syöttämäsi tiedot.");
                    return;
                }

                // Tehdään laskennat jos syötetyt arvot ovat ok
                double bruttopalkka = (normaalitunnit * tuntipalkka) + (ylityotunnit * tuntipalkka * 1.5);
                double veroprosentti = LaskeVeroprosentti(bruttopalkka); // kutsutaan LaskeVeroProsentti metodi
                double verot = bruttopalkka * (veroprosentti / 100);
                double nettopalkka = bruttopalkka - verot;

                // Tulostus
                txtResult.Text = $"Työntekijän nimi: {tyontekija}{Environment.NewLine}Bruttopalkka: {bruttopalkka:F2} €{Environment.NewLine}" +
                    $"Veroprosentti: {veroprosentti:F2} %{Environment.NewLine}Verot: {verot:F2} €{Environment.NewLine}Nettopalkka: {nettopalkka:F2} €";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe: {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUusiTyontekija_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnTallenna_Click(object sender, EventArgs e)
        {
            try
            {
                // tallentaa tulostetut palkkatiedot tiedostoon "Palkatiedot" ja lisää päivämäärän
                // tallennetaan txtResult tiedot muuttujaan
                string palkkaTiedot = txtResult.Text;

                // tarkastetaan että syötä on generoitu txtResult kenttään ennen tallennusta
                if (txtResult.Text.Length == 0)
                {
                    MessageBox.Show("Palkkateitoja ei ole genereoitu.");
                    return;
                }
                else
                {
                    // Lisätään generoitu teksti Palkkatiedot.txt tiedostoon sekä päivämäärä
                    File.AppendAllText(PayDataFilePath, palkkaTiedot + Environment.NewLine + DateTime.Now.Date.ToString("MM/dd/yyyy hh:mm tt") + Environment.NewLine + "-------------" + Environment.NewLine);
                    MessageBox.Show("Palkkatiedot tallennettu onnistuneesti Palkkatiedot.txt teksti tiedostoon");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe: {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        private void btnUusiTyontekija_Click(object sender, EventArgs e)
        {
            try
            {
                // tallenetaan uusi työntekijä työntekijät listaan
                string uusiTyontekija = txtUusiTyontekija.Text.Trim();

                // tarkistetaan että uuden työntekijän nimi on syötetty
                if (uusiTyontekija.Length == 0)
                {
                    MessageBox.Show("Anna lisättävän työntekijän nimi.");
                    return;
                }
                else
                {
                    // lisätään uusi työntekijä comboboxiin ja listaan
                    _ = TyonTekijatComboBox.Items.Add(uusiTyontekija);
                    File.AppendAllText(DataFilePath, uusiTyontekija + Environment.NewLine);

                    MessageBox.Show($"Työntekijä {uusiTyontekija} lisätty.");


                    txtUusiTyontekija.Text = "";// tyhjennetään tekstikenttä
                }
                JarjestaAakkosJarjestykseen(); // järjestetään aakkosjärjestykseen
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe: {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnPoistatyontekija_Click(object sender, EventArgs e)
        {
            try
            {
                // tallennetaan poistettavan työntekijän nimi
                string poistaTyontekija = txtUusiTyontekija.Text.Trim();

                // tarkistetaan että uuden työntekijän nimi on syötetty
                if (poistaTyontekija.Length == 0)
                {
                    MessageBox.Show("Anna poistettavan työntekijän nimi.");
                    return;
                }

                // luetaan listan kaikki rivit
                var tyontekijat = File.ReadAllLines(DataFilePath).ToList();

                // tarkistetaan onko poistettava työntekijä listassa
                if (!tyontekijat.Contains(poistaTyontekija))
                {
                    MessageBox.Show("Työntekijää ei löytynyt.");
                    return;
                }

                tyontekijat.Remove(poistaTyontekija); // poistetaan työntekijä jos löytyy listasta
                File.WriteAllLines(DataFilePath, tyontekijat); // kirjoitetaan tiedosto uudestaan

                // päivitetään ComboBox
                TyonTekijatComboBox.Items.Clear();
                TyonTekijatComboBox.Items.AddRange(tyontekijat.ToArray());

                JarjestaAakkosJarjestykseen(); // järjestetään aakkosjärjestykseen

                MessageBox.Show($"Työntekijä {poistaTyontekija} poistettu.");
                txtUusiTyontekija.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe: {ex.Message}", "Virhe", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TyonTekijatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


    }
}
// lisää työntekiojät listaan ja poista niin että säilyy 
// näytä työntekijöliden määrä
// aseta tekijöille tuntipalkat riippuen ammatti nimikkeestä
// lisää nappi mikä näyttää tiedoston mihin tallennettu palkkatiedot