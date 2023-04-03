using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesoCC
{
    public partial class TesterCarne : Form
    {
        private QR qr;

        public TesterCarne()
        {
            InitializeComponent();
            this.qr = new QR();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qr.RandQR();

            pictureBox1.Image = qr.RandImage;
            labelCod.Text = qr.RandText;
        }
    }
}
