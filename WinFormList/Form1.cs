using System.Globalization;
using System.Windows.Forms;

namespace WinFormList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Liste_MeyveSebze = new List<string>();
        List<double> Liste_Kilo = new List<double>();
        List<double> Liste_Fiyat = new List<double>();

        private void ekleButton_Click(object sender, EventArgs e)
        {

            Liste_MeyveSebze.Add(textBox1.Text);
            Liste_Kilo.Add(double.Parse(textBox2.Text));
            Liste_Fiyat.Add(double.Parse(textBox3.Text));

            string sonuc = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            alisverisListesi.Items.Add(sonuc);
        }
        private void temizleButton_Click(object sender, EventArgs e)
        {
            alisverisListesi.Items.Clear();
            toplamBox.Clear();
        }
        private void toplamButton_Click(object sender, EventArgs e)
        {
            double toplamTutar = 0;
            foreach (var item in alisverisListesi.Items)
            {
                string[] meyveBilgileri = item.ToString().Split(' ');
                double kilo = Convert.ToDouble(meyveBilgileri[1]);
                double fiyat = Convert.ToDouble(meyveBilgileri[2]);
                toplamTutar += kilo * fiyat;
            }
            toplamBox.Text = toplamTutar.ToString("N2");

        }
    }

}