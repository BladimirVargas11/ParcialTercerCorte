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
    public partial class Form1 : Form
    {



        private List<Ips> listaIps;
        private List<Laboratorio> listaLaboratorio;
        private List<Servicio> listaServicio;
        private LaboratorioService laboratorioService;
        private IpsService ipsService;
        private ServicioService servicioService;
        private ServicioBdService servicioBdService;
        public Form1()
        {
            InitializeComponent();

            ipsService = new IpsService(ConfigConnection.connectionString);
            servicioBdService = new ServicioBdService(ConfigConnection.connectionString);
            laboratorioService = new LaboratorioService(ConfigConnection.connectionString);
            CargarIps();
            CargarLaboratorio();
            BotonGuardar.Enabled = false;


        }

        private void BotonAbrir_Click(object sender, EventArgs e)
        {
            if (ComboIps.Text.Equals(""))
            {
                MessageBox.Show("Seleccione una IPS");
            }
            else
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != null)
                {
                    var fileStream = openFileDialog1.OpenFile();
                    servicioService = new ServicioService(fileStream);
                    var respuesta = servicioService.Consultar();
                    if (respuesta.Error)
                    {
                        MessageBox.Show("No se ha podido mostrar los datos en la tabla, Verifique Su Archivo");
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        if (ValidarDatosIps(respuesta.listaServicio))
                        {
                            listaServicio = respuesta.listaServicio;
                            dataGridView1.DataSource = listaServicio;
                            BotonGuardar.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Datos no coinciden con el IPS seleccionado, Verifique los datos de su archivo");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("No se ha podido mostrar los datos en la tabla");
                }
            }
        }

        public bool ValidarDatosIps(List<Servicio> servicios) {
            Ips ips = ObtenerIps();
            int contadorOk = 0;
            int contadorError = 0;
            if (ips != null)
            {
                foreach (var item in servicios) {
                    if (item.IdIPS.Equals(ips.IdIPS))
                    {
                        contadorOk++;
                    }
                    else {
                        contadorError++;
                    }
                }

            }
            else {
                MessageBox.Show("No se ha podido encontrar los datos de las IPS.");
                return false;
            }
            if (contadorError == 0)
            {
                return true;
            }
            else {
                return false;
            }

        }
        public Ips ObtenerIps() {
            foreach (var item in listaIps)
            {
                if (ComboIps.Text.Equals(item.NombreIPS))
                {
                    return item;
                }

            }
            return null;
        }
        public void Guardar() {
            
            int contadorOk = 0;
            int contadorError = 0;
            String mensajeRuta = "";
            foreach (var item in listaServicio)
            {
                if (ValorLaboratorio(item.IdLaboratorio, item.ValorLaboratorio))
                {
                    servicioBdService.GuardarServicio(item);
                    contadorOk++;
                }
                else {
                    decimal valor= ValorRealLaboratorio(item.IdLaboratorio);
                     mensajeRuta = servicioService.GuardarArchivo(item, valor );
                    contadorError++;
                }
            }
            if (contadorError > 0)
            {
                MessageBox.Show("Los Datos correctos son: " + contadorOk + "\nLos Datos Incorrectos son: " + contadorError + "\nVerifiqueLaRuta:"+ mensajeRuta, "INFORMACION SOBRE EL ARCHIVO");

            }
            else {
                MessageBox.Show("Se han guardado todos los datos satisfactoriamente", "INFORMACION SOBRE EL ARCHIVO");
            }
        }
        private bool ValorLaboratorio(String id, decimal valor) {
            foreach (var item in listaLaboratorio) {
                if (id.Equals(item.IdLaboratorios)) {
                    if (valor == item.ValorLaboratorio) {
                        return true;
                    }
                }
            }
            return false;
        }
        private decimal ValorRealLaboratorio(String id)
        {
            foreach (var item in listaLaboratorio)
            {
                if (id.Equals(item.IdLaboratorios))
                {
                    return item.ValorLaboratorio; 
                }
            }
            return 0;
        }
        private void CargarLaboratorio() {
            var response = laboratorioService.ConsultaLaboratorio();
            listaLaboratorio = response.ListaLaboratorio;
        }
        private void CargarIps() {
            
            var response = ipsService.ConsultaIps();
            listaIps = response.ListaIps;
            
           
            foreach (var item in listaIps) {

                ComboIps.Items.Add(item.NombreIPS);
            }


        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BotonConsultar_Click(object sender, EventArgs e)
        {
            FrmConsultas frmConsultas = new FrmConsultas(listaIps,listaLaboratorio);
            frmConsultas.Show();
        }
    }
}
