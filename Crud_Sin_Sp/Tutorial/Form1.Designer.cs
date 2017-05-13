namespace Tutorial
{
    partial class formPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pformIngreso = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pMostrar = new System.Windows.Forms.Panel();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.pformIngreso.SuspendLayout();
            this.pMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pformIngreso
            // 
            this.pformIngreso.Controls.Add(this.dtpFecha);
            this.pformIngreso.Controls.Add(this.txtApellidos);
            this.pformIngreso.Controls.Add(this.txtNombre);
            this.pformIngreso.Controls.Add(this.txtId);
            this.pformIngreso.Controls.Add(this.label4);
            this.pformIngreso.Controls.Add(this.label3);
            this.pformIngreso.Controls.Add(this.label2);
            this.pformIngreso.Controls.Add(this.label1);
            this.pformIngreso.Location = new System.Drawing.Point(12, 47);
            this.pformIngreso.Name = "pformIngreso";
            this.pformIngreso.Size = new System.Drawing.Size(333, 164);
            this.pformIngreso.TabIndex = 0;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(103, 131);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(97, 88);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 20);
            this.txtApellidos.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(97, 57);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // pMostrar
            // 
            this.pMostrar.Controls.Add(this.dgvPersona);
            this.pMostrar.Location = new System.Drawing.Point(13, 241);
            this.pMostrar.Name = "pMostrar";
            this.pMostrar.Size = new System.Drawing.Size(459, 159);
            this.pMostrar.TabIndex = 1;
            // 
            // dgvPersona
            // 
            this.dgvPersona.AllowUserToAddRows = false;
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Location = new System.Drawing.Point(3, 17);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.Size = new System.Drawing.Size(437, 150);
            this.dgvPersona.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnModificar);
            this.panel2.Controls.Add(this.btnCrear);
            this.panel2.Controls.Add(this.btnConsultar);
            this.panel2.Location = new System.Drawing.Point(385, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(87, 164);
            this.panel2.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(0, 129);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Elliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(0, 88);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(0, 52);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 1;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(0, 17);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 0;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(385, 212);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(75, 23);
            this.btnReporte.TabIndex = 3;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // formPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 412);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pMostrar);
            this.Controls.Add(this.pformIngreso);
            this.Name = "formPersona";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formPersona_Load);
            this.pformIngreso.ResumeLayout(false);
            this.pformIngreso.PerformLayout();
            this.pMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pformIngreso;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pMostrar;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnReporte;
    }
}

