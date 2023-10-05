namespace Conexion_Capas
{
    partial class FRMprincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAMB = new System.Windows.Forms.Button();
            this.BTNVentas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Clientes";
            // 
            // BtnAMB
            // 
            this.BtnAMB.Location = new System.Drawing.Point(33, 200);
            this.BtnAMB.Name = "BtnAMB";
            this.BtnAMB.Size = new System.Drawing.Size(87, 54);
            this.BtnAMB.TabIndex = 63;
            this.BtnAMB.Text = "AMB Clientes";
            this.BtnAMB.UseVisualStyleBackColor = true;
            this.BtnAMB.Click += new System.EventHandler(this.BtnAMB_Click);
            // 
            // BTNVentas
            // 
            this.BTNVentas.Location = new System.Drawing.Point(620, 74);
            this.BTNVentas.Name = "BTNVentas";
            this.BTNVentas.Size = new System.Drawing.Size(103, 42);
            this.BTNVentas.TabIndex = 64;
            this.BTNVentas.Text = "Ventas";
            this.BTNVentas.UseVisualStyleBackColor = true;
            this.BTNVentas.Click += new System.EventHandler(this.BTNVentas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(633, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 66;
            this.label3.Text = "Ventas";
            // 
            // BtnClientes
            // 
            this.BtnClientes.Location = new System.Drawing.Point(33, 74);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(87, 54);
            this.BtnClientes.TabIndex = 67;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // FRMprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(827, 463);
            this.Controls.Add(this.BtnClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNVentas);
            this.Controls.Add(this.BtnAMB);
            this.Controls.Add(this.label1);
            this.Name = "FRMprincipal";
            this.Text = "principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAMB;
        private System.Windows.Forms.Button BTNVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnClientes;
    }
}

