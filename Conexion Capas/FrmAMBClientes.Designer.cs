namespace Conexion_Capas
{
    partial class FrmAMBClientes
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
            this.BTNcargar = new System.Windows.Forms.Button();
            this.BTNcancelar = new System.Windows.Forms.Button();
            this.BTNaceptar = new System.Windows.Forms.Button();
            this.BTNeliminar = new System.Windows.Forms.Button();
            this.BTNmodificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTbuscar = new System.Windows.Forms.TextBox();
            this.DG1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTid = new System.Windows.Forms.TextBox();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblnacimiento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.TXTdireccion = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNcargar
            // 
            this.BTNcargar.Enabled = false;
            this.BTNcargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNcargar.Location = new System.Drawing.Point(417, 66);
            this.BTNcargar.Name = "BTNcargar";
            this.BTNcargar.Size = new System.Drawing.Size(79, 22);
            this.BTNcargar.TabIndex = 76;
            this.BTNcargar.Text = "<<";
            this.BTNcargar.UseVisualStyleBackColor = true;
            this.BTNcargar.Click += new System.EventHandler(this.BTNcargar_Click);
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Enabled = false;
            this.BTNcancelar.Location = new System.Drawing.Point(268, 226);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(79, 33);
            this.BTNcancelar.TabIndex = 75;
            this.BTNcancelar.Text = "&Cancelar";
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // BTNaceptar
            // 
            this.BTNaceptar.Enabled = false;
            this.BTNaceptar.Location = new System.Drawing.Point(146, 226);
            this.BTNaceptar.Name = "BTNaceptar";
            this.BTNaceptar.Size = new System.Drawing.Size(79, 33);
            this.BTNaceptar.TabIndex = 63;
            this.BTNaceptar.Text = "Aceptar";
            this.BTNaceptar.UseVisualStyleBackColor = true;
            this.BTNaceptar.Click += new System.EventHandler(this.BTNaceptar_Click);
            // 
            // BTNeliminar
            // 
            this.BTNeliminar.Location = new System.Drawing.Point(12, 178);
            this.BTNeliminar.Name = "BTNeliminar";
            this.BTNeliminar.Size = new System.Drawing.Size(79, 33);
            this.BTNeliminar.TabIndex = 74;
            this.BTNeliminar.Text = "&Eliminar";
            this.BTNeliminar.UseVisualStyleBackColor = true;
            this.BTNeliminar.Click += new System.EventHandler(this.BTNeliminar_Click);
            // 
            // BTNmodificar
            // 
            this.BTNmodificar.Location = new System.Drawing.Point(12, 120);
            this.BTNmodificar.Name = "BTNmodificar";
            this.BTNmodificar.Size = new System.Drawing.Size(79, 33);
            this.BTNmodificar.TabIndex = 73;
            this.BTNmodificar.Text = "&Modificar";
            this.BTNmodificar.UseVisualStyleBackColor = true;
            this.BTNmodificar.Click += new System.EventHandler(this.BTNmodificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(358, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Clientes";
            // 
            // TXTbuscar
            // 
            this.TXTbuscar.Enabled = false;
            this.TXTbuscar.Location = new System.Drawing.Point(532, 66);
            this.TXTbuscar.Name = "TXTbuscar";
            this.TXTbuscar.Size = new System.Drawing.Size(121, 20);
            this.TXTbuscar.TabIndex = 71;
            this.TXTbuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TXTbuscar_KeyUp);
            // 
            // DG1
            // 
            this.DG1.AllowUserToAddRows = false;
            this.DG1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DG1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG1.Location = new System.Drawing.Point(417, 98);
            this.DG1.Name = "DG1";
            this.DG1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DG1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DG1.Size = new System.Drawing.Size(478, 150);
            this.DG1.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(182, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 69;
            this.label2.Text = "ID";
            // 
            // TXTid
            // 
            this.TXTid.Enabled = false;
            this.TXTid.Location = new System.Drawing.Point(246, 72);
            this.TXTid.Name = "TXTid";
            this.TXTid.Size = new System.Drawing.Size(86, 20);
            this.TXTid.TabIndex = 68;
            // 
            // BTNagregar
            // 
            this.BTNagregar.Location = new System.Drawing.Point(12, 59);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(79, 33);
            this.BTNagregar.TabIndex = 58;
            this.BTNagregar.Text = "&Agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(246, 150);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(120, 20);
            this.txtDNI.TabIndex = 61;
            // 
            // lblnacimiento
            // 
            this.lblnacimiento.AutoSize = true;
            this.lblnacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnacimiento.Location = new System.Drawing.Point(160, 189);
            this.lblnacimiento.Name = "lblnacimiento";
            this.lblnacimiento.Size = new System.Drawing.Size(65, 16);
            this.lblnacimiento.TabIndex = 67;
            this.lblnacimiento.Text = "Direccion";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(246, 124);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 20);
            this.txtApellido.TabIndex = 60;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(182, 128);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(58, 16);
            this.lblApellido.TabIndex = 66;
            this.lblApellido.Text = "Apellido";
            // 
            // TXTdireccion
            // 
            this.TXTdireccion.Enabled = false;
            this.TXTdireccion.Location = new System.Drawing.Point(246, 185);
            this.TXTdireccion.Name = "TXTdireccion";
            this.TXTdireccion.Size = new System.Drawing.Size(120, 20);
            this.TXTdireccion.TabIndex = 62;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(182, 154);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(31, 16);
            this.lblDNI.TabIndex = 65;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(182, 102);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 16);
            this.lblNombre.TabIndex = 64;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(246, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 20);
            this.txtNombre.TabIndex = 59;
            // 
            // FrmAMBClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 440);
            this.Controls.Add(this.BTNcargar);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.BTNaceptar);
            this.Controls.Add(this.BTNeliminar);
            this.Controls.Add(this.BTNmodificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTbuscar);
            this.Controls.Add(this.DG1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TXTid);
            this.Controls.Add(this.BTNagregar);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblnacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.TXTdireccion);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmAMBClientes";
            this.Text = "AMB Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNcargar;
        private System.Windows.Forms.Button BTNcancelar;
        private System.Windows.Forms.Button BTNaceptar;
        private System.Windows.Forms.Button BTNeliminar;
        private System.Windows.Forms.Button BTNmodificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTbuscar;
        private System.Windows.Forms.DataGridView DG1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTid;
        private System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblnacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox TXTdireccion;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
    }
}