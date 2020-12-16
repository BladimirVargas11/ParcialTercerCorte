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
        private LaboratorioService laboratorioService;
        private IpsService ipsService;
        private ServicioService servicioService;
        private ServicioBdService servicioBdService;
        public Form1()
        {
            InitializeComponent();
            
            ipsService = new IpsService(ConfigConnection.connectionString);
            servicioBdService = new ServicioBdService(ConfigConnection.connectionString);
            CargarIps(); 
            

        }

        private void BotonAbrir_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != null && !ComboIps.Text.Equals(""))
            {
                var fileStream = openFileDialog1.OpenFile();
                servicioService = new ServicioService(fileStream);
                string Ruta = openFileDialog1.FileName.ToString();
                var respuesta = servicioService.Consultar();
                if (respuesta.Error)
                {
                    MessageBox.Show("No se ha podido mostrar los datos en la tabla, Verifique Su Archivo");
                }
                else {
                    if (ValidarDatos(respuesta.listaServicio, Ruta)) {

                        dataGridView1.DataSource = respuesta.listaServicio;
                    }
                    
                }


            }
            else {

                MessageBox.Show("No se ha podido mostrar los datos en la tabla");
            }
        }
        public bool ValidarDatos(List<Servicio> servicios,String ruta ) {
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
            MessageBox.Show("Los Datos correctos son: "+contadorOk+ "\nLos Datos Incorrectos son: " + contadorError + "\nSu ruta es:" + ruta,"INFORMACION SOBRE EL ARCHIVO");
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
        public void Guardar(List<Servicio> liquidaciones) {

            foreach (var item in liquidaciones)
            {
                 
                MessageBox.Show(servicioBdService.Guardar(item));
                
            }
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
    }
}
