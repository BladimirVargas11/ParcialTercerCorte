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
            dataGridView1.Rows.Clear();
            if (comboBox1.Text.Equals("Laboratorio Yesenia Ovalle") || comboBox1.Text.Equals("Laboratorio Nacy Florez") || comboBox1.Text.Equals("Laboratorio Cristiam Gram"))
            {
                Ips ips = ObtenerIps();
                var RESPUESTA = servicioBdService.ConsultarTodos(comboBox1.Text, ips.IdIPS);
                PintarConIps(RESPUESTA.servicios, ips);
            }
            else {
                Laboratorio laboratorio = ObtenerLaboratorio();
                var response = servicioBdService.ConsultarTodos(comboBox1.Text, laboratorio.IdLaboratorios);
                PintarConLaboratorio(response.servicios, laboratorio);
                
            }
        }
        public void PintarConLaboratorio(List<Servicio> listaConsulta,Laboratorio laboratorio) {
            foreach (var item in listaConsulta)
            {
                Ips ips = ObtenerIps(item.IdIPS);
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = ips.IdIPS;
                dataGridView1.Rows[n].Cells[1].Value = ips.NombreIPS;
                dataGridView1.Rows[n].Cells[2].Value = item.Identificacion;
                dataGridView1.Rows[n].Cells[3].Value = item.NombrePaciente;
                dataGridView1.Rows[n].Cells[4].Value = laboratorio.IdLaboratorios;
                dataGridView1.Rows[n].Cells[5].Value = laboratorio.NombreLaboratorios;
                dataGridView1.Rows[n].Cells[6].Value = item.ValorLaboratorio;
            }

        }
        public void PintarConIps(List<Servicio> listaConsulta, Ips ips)
        {
            foreach (var item in listaConsulta)
            {
                Laboratorio laboratorio = ObtenerLaboratorio(item.IdLaboratorio);
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = ips.IdIPS;
                dataGridView1.Rows[n].Cells[1].Value = ips.NombreIPS;
                dataGridView1.Rows[n].Cells[2].Value = item.Identificacion;
                dataGridView1.Rows[n].Cells[3].Value = item.NombrePaciente;
                dataGridView1.Rows[n].Cells[4].Value = laboratorio.IdLaboratorios;
                dataGridView1.Rows[n].Cells[5].Value = laboratorio.NombreLaboratorios;
                dataGridView1.Rows[n].Cells[6].Value = item.ValorLaboratorio;
            }

        }
        public Ips ObtenerIps(string id)
        {
            foreach (var item in listaIps)
            {
                if (id.Equals(item.IdIPS))
                {
                    return item;
                }
            }
            return null;
        }
        public Ips ObtenerIps()
        {
            foreach (var item in listaIps) {
                if (comboBox1.Text.Equals(item.NombreIPS)) {
                    return item;
                }
            }
            return null;
        }
        public Laboratorio ObtenerLaboratorio()
        {
            foreach (var item in listaLaboratorio)
            {
                if (comboBox1.Text.Equals(item.NombreLaboratorios))
                {
                    return item;
                }
            }
            return null;
        }
        public Laboratorio ObtenerLaboratorio(String id)
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
