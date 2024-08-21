using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_PROG3_JUSTINALEON
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "") //si el texto es distinto de vacio, o sea tiene datos, agrego un nombre
            {
                //agrego lo que haya en el textbox en el listBox
                lbNombres.Items.Add(txtNombre.Text);
                //limpiar el textbox(reiniciar)
                txtNombre.Text = "";
            }
            else //sino muestro un cartel aclaratorio
            {
                MessageBox.Show("No pueden haber espacios vacios, intentelo de nuevo");
            }
        }
    }
}
