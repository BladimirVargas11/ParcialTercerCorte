﻿namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonAbrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboIps = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BotonGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonAbrir
            // 
            this.BotonAbrir.Location = new System.Drawing.Point(321, 36);
            this.BotonAbrir.Name = "BotonAbrir";
            this.BotonAbrir.Size = new System.Drawing.Size(75, 23);
            this.BotonAbrir.TabIndex = 0;
            this.BotonAbrir.Text = "ABRIR";
            this.BotonAbrir.UseVisualStyleBackColor = true;
            this.BotonAbrir.Click += new System.EventHandler(this.BotonAbrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos TXT (*.txt)|*.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "IPS:";
            // 
            // ComboIps
            // 
            this.ComboIps.FormattingEnabled = true;
            this.ComboIps.Location = new System.Drawing.Point(151, 36);
            this.ComboIps.Name = "ComboIps";
            this.ComboIps.Size = new System.Drawing.Size(121, 21);
            this.ComboIps.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 243);
            this.dataGridView1.TabIndex = 7;
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(693, 379);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(75, 23);
            this.BotonGuardar.TabIndex = 8;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 414);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ComboIps);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotonAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonAbrir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboIps;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BotonGuardar;
    }
}

