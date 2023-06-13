namespace Parola_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool EnAzBirBuyukHarfVarMi(string sifre)
        {
            foreach (var harf in sifre)
            {
                if (Char.IsUpper(harf))
                    return true;
            }
            return false;
        }
        private bool EnAzBirKucukHarfVarMi(string sifre)
        {
            foreach (var harf in sifre)
            {
                if (Char.IsLower(harf))
                    return true;
            }
            return false;
        }
        private bool EnAzBirDigerKarakterVarMi(string sifre)
        {
            foreach (var harf in sifre)
            {
                if (harf == '!' || harf == '.' || harf == ':')
                    return true;
            }
            return false;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            lblSonuc.Text = "";
            string sifre = txtSifre.Text;
            if (sifre.Length < 8)
            {
                lblSonuc.Text += "GUCSUZ";
                lblSonuc.ForeColor = Color.Red;
            }
            else if (EnAzBirKucukHarfVarMi(sifre) && EnAzBirBuyukHarfVarMi(sifre) && !EnAzBirDigerKarakterVarMi(sifre))
            {
                lblSonuc.Text += "ORTA";
                lblSonuc.ForeColor = Color.Orange;
            }
            else if (EnAzBirKucukHarfVarMi(sifre) && EnAzBirBuyukHarfVarMi(sifre) && EnAzBirDigerKarakterVarMi(sifre))
            {
                lblSonuc.Text += "GUCLU";
                lblSonuc.ForeColor = Color.Green;
            }
            else
            {
                lblSonuc.Text += "GUCSUZ";
                lblSonuc.ForeColor = Color.Red;
            }
        }
    }
}