﻿using System;
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
        

        private List<Servicio> listaServicio;
        private List<Ips> listaIps;

        private IpsService ipsService;
        private ServicioService servicioService;
        private ServicioBdService servicioBdService;
        public Form1()
        {
            InitializeComponent();
            
            ipsService = new IpsService(ConfigConnection.connectionString);
            servicioBdService = new ServicioBdService(ConfigConnection.connectionString);
            CargarSedes(); 
            

        }

        private void BotonAbrir_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.FileName != null)
            {
                var fileStream = openFileDialog1.OpenFile();
                servicioService = new ServicioService(fileStream);
                var respuesta = servicioService.Consultar();
                if (respuesta.Error)
                {
                    MessageBox.Show("NO se ha podido mostrar los datos en la tabla, Verifique Su Archivo");
                }
                else {
                    ValidarDatos(respuesta.listaServicio);
                    dataGridView1.DataSource = respuesta.listaServicio;
                }
                
                
            }
        }
        public void ValidarDatos(Servicio servicio) { 
        
        
        }
        public void Guardar(List<Servicio> liquidaciones) {

            foreach (var item in liquidaciones)
            {
                 
                MessageBox.Show(servicioBdService.Guardar(item));
                
            }
        }

        private void CargarSedes() {
            
            var response = ipsService.ConsultaIps();
            listaIps = response.ListaIps;
            
           
            foreach (var item in listaIps) {

                ComboSede.Items.Add(item.NombreIPS);
            }


        }
    }
}
