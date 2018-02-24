using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HoroscopoChino
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnArchivoTexto_Click(object sender, EventArgs e)
        {
            txtArchivoTexto.Clear();
            var result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtArchivoTexto.Text = openFileDialog.FileName;
            }
        }

        private void btnArchivoXml_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Archivo xml|*.xml";
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                HoroscopoChino horoscopo = new HoroscopoChino();
                horoscopo.Obtener_Horoscopos(txtArchivoTexto.Text);

                horoscopo.GuardarComoXml(saveFileDialog.FileName);

                MessageBox.Show("Archivo XML guardado con éxito");
            }

            
        }

        private void btnArchivoJson_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Archivo json|*.json";
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                HoroscopoChino horoscopo = new HoroscopoChino();
                horoscopo.Obtener_Horoscopos(txtArchivoTexto.Text);

                horoscopo.GuardarComoJson(saveFileDialog.FileName);

                MessageBox.Show("Archivo JSON guardado con éxito");
            }
        }
    }
}
