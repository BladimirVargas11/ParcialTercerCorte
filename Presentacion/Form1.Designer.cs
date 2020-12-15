namespace Presentacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboVigencia = new System.Windows.Forms.ComboBox();
            this.ComboPeriodo = new System.Windows.Forms.ComboBox();
            this.ComboSede = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdSede = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vigencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonAbrir
            // 
            this.BotonAbrir.Location = new System.Drawing.Point(303, 71);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vigencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sede:";
            // 
            // ComboVigencia
            // 
            this.ComboVigencia.FormattingEnabled = true;
            this.ComboVigencia.Location = new System.Drawing.Point(126, 40);
            this.ComboVigencia.Name = "ComboVigencia";
            this.ComboVigencia.Size = new System.Drawing.Size(121, 21);
            this.ComboVigencia.TabIndex = 4;
            // 
            // ComboPeriodo
            // 
            this.ComboPeriodo.FormattingEnabled = true;
            this.ComboPeriodo.Location = new System.Drawing.Point(126, 81);
            this.ComboPeriodo.Name = "ComboPeriodo";
            this.ComboPeriodo.Size = new System.Drawing.Size(121, 21);
            this.ComboPeriodo.TabIndex = 5;
            // 
            // ComboSede
            // 
            this.ComboSede.FormattingEnabled = true;
            this.ComboSede.Location = new System.Drawing.Point(126, 124);
            this.ComboSede.Name = "ComboSede";
            this.ComboSede.Size = new System.Drawing.Size(121, 21);
            this.ComboSede.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdSede,
            this.IdEmpleado,
            this.NombreEmpleado,
            this.Horas,
            this.Periodo,
            this.Vigencia});
            this.dataGridView1.Location = new System.Drawing.Point(82, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 243);
            this.dataGridView1.TabIndex = 7;
            // 
            // IdSede
            // 
            this.IdSede.HeaderText = "IDSEDE";
            this.IdSede.Name = "IdSede";
            this.IdSede.ReadOnly = true;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "IDEMPLEADO";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.HeaderText = "NOMBRE EMPLEADO";
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.ReadOnly = true;
            // 
            // Horas
            // 
            this.Horas.HeaderText = "HORAS";
            this.Horas.Name = "Horas";
            this.Horas.ReadOnly = true;
            // 
            // Periodo
            // 
            this.Periodo.HeaderText = "PERIODO";
            this.Periodo.Name = "Periodo";
            this.Periodo.ReadOnly = true;
            // 
            // Vigencia
            // 
            this.Vigencia.HeaderText = "VIGENCIA";
            this.Vigencia.Name = "Vigencia";
            this.Vigencia.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 543);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ComboSede);
            this.Controls.Add(this.ComboPeriodo);
            this.Controls.Add(this.ComboVigencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboVigencia;
        private System.Windows.Forms.ComboBox ComboPeriodo;
        private System.Windows.Forms.ComboBox ComboSede;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSede;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vigencia;
    }
}

