using Microsoft.VisualBasic;
using System.Windows.Forms;
namespace Konversi_Suhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCelcius_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            double celcius, fahrenheit, reamur, kelvin;
            celcius = Convert.ToInt64(txtInput.Text);
            fahrenheit = 9 / 5 * celcius + 32;
            reamur = 4 / 5 * celcius;
            kelvin = celcius + 273;

            
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}