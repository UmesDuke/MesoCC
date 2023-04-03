using System;
using System.Text;
using System.Windows.Forms;

namespace MesoCC
{
    public partial class ValidarCarne : Form
    {
        private ISBN10 ISBN_10;
        private QR qr;
        public ValidarCarne()
        {
            InitializeComponent();
            ComponentesAdd();
        }

        private void ComponentesAdd()
        {
            ISBN_10 = new ISBN10();
            qr = new QR();
        }

        private bool IsCarneValido(string carne)
        {
            if (carne == null || carne.Length != 9)
            {
                return false;
            }

            StringBuilder buff = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                char car = carne[i];
                if (!char.IsNumber(car))
                {
                    return false;
                }
                buff.Append(car);
            }

            int a = Convert.ToInt32(buff.ToString());
            if (a < 2009)
            {
                return false;
            }

            DateTime now = DateTime.Now;
            if (a > now.Year)
            {
                return false;
            }
            return true;
        }

        private void GenerarQR(string code)
        {
            pictureBox1.Image = qr.GenerarQR(code);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = null;
            pictureBox1.Image = null;

            string val = this.textBox1.Text.Trim();
            if (!IsCarneValido(val))
            {
                MessageBox.Show("No. Carné invalido...");
            }
            else
            {
                if (!ISBN_10.SetBase(val))
                {
                    MessageBox.Show("Error al validar. Porfavor verifique e intente de nuevo.");
                    return;
                }
                string cod = ISBN_10.GetISB10();

                if ( cod == null || cod.Length == 0 )
                {
                    MessageBox.Show("Error al validar. Porfavor verifique e intente de nuevo.");
                } 
                else
                {
                    label3.Text = cod;
                    GenerarQR(cod);
                }
            }
        }
    }
}
