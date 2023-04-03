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
    public partial class Form1 : Form
    {
        private Form formularoActual = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void OcultarSubMenu()
        {
            panelSubMenuEstudiante.Visible = false;
        }

        private void MostrarSubMenu()
        {
            if (!panelSubMenuEstudiante.Visible )
            {
                panelSubMenuEstudiante.Visible = true;
            } else
            {
                panelSubMenuEstudiante.Visible = false;
            }
        }

        private void MostrarContenedor(Form obj)
        {
            if ( formularoActual != null )
            {
                formularoActual.Close();
            }
            formularoActual = obj;
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;

            panelContainer.Controls.Add(obj);
            panelContainer.Tag = obj;

            obj.BringToFront();
            obj.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            OcultarSubMenu();
        }

        private void buttonEstudiante_Click(object sender, EventArgs e)
        {
            MostrarSubMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarContenedor(new ValidarCarne());
            OcultarSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarContenedor(new TesterCarne());
            OcultarSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
