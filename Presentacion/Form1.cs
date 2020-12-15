using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextoArchivo.ReadOnly = true;
        }

        private void BotonAbrir_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != null)
            {
                string file = openFileDialog1.FileName;
                //string mensaje = ProductoSedeService.Guardar(file); // Crear la clase ProductoSedeService y el método guardar
                //MessageBox.Show(mensaje);
                TextoArchivo.Text = openFileDialog1.FileName;
            }
        }
    }
}
