using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Logica;


namespace Presentacion
{
    public partial class FrmConsultas : Form
    {
        private List<Ips> listaIps;
        private List<Laboratorio> listaLaboratorio;
        private ServicioBdService servicioBdService;
        public FrmConsultas()
        {
            InitializeComponent();
        }

        public FrmConsultas(List<Ips> listIps, List<Laboratorio> listLaboratorio)
        {
            InitializeComponent();
            servicioBdService = new ServicioBdService(ConfigConnection.connectionString);
            listaIps = listIps;
            listaLaboratorio = listLaboratorio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("Seleccione una categoria.");
            }
            else
            {
                consultar();
            }
            
        }
        public void consultar() {
            if (comboBox1.Text.Equals("Laboratorio Yesenia Ovalle") || comboBox1.Text.Equals("Laboratorio Nacy Florez") || comboBox1.Text.Equals("Laboratorio Cristiam Gram"))
            {
                Ips ips = new Ips();
                dataGridView1.DataSource = servicioBdService.ConsultarTodos(comboBox1.Text, ips.IdIPS);
            }
            else {
                Laboratorio laboratorio = new Laboratorio();
                dataGridView1.DataSource = servicioBdService.ConsultarTodos(comboBox1.Text, laboratorio.IdLaboratorios);

            }
        }
        
        public Ips ObtenerIps()
        {
            foreach (var item in listaIps) {
                if (comboBox1.Text.Equals(item.IdIPS)) {
                    return item;
                }
            }
            return null;
        }
        public Laboratorio ObtenerLaboratorio(string id)
        {
            foreach (var item in listaLaboratorio)
            {
                if (id.Equals(item.IdLaboratorios))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
