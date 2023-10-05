namespace Conexion_Capas
{
    partial class FRMVentas
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
            this.lbCargarPor = new System.Windows.Forms.Label();
            this.DGTablaVentas = new System.Windows.Forms.DataGridView();
            this.BTNcargarDG = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVentas = new System.Windows.Forms.DataGridView();
            this.BtnVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGTablaVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCargarPor
            // 
            this.lbCargarPor.AutoSize = true;
            this.lbCargarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargarPor.Location = new System.Drawing.Point(12, 19);
            this.lbCargarPor.Name = "lbCargarPor";
            this.lbCargarPor.Size = new System.Drawing.Size(336, 16);
            this.lbCargarPor.TabIndex = 63;
            this.lbCargarPor.Text = "Tabla Ventas (como esta en la Base de Datos) ";
            // 
            // DGTablaVentas
            // 
            this.DGTablaVentas.AllowUserToAddRows = false;
            this.DGTablaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGTablaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGTablaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTablaVentas.Location = new System.Drawing.Point(12, 51);
            this.DGTablaVentas.Name = "DGTablaVentas";
            this.DGTablaVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGTablaVentas.Size = new System.Drawing.Size(355, 150);
            this.DGTablaVentas.TabIndex = 62;
            // 
            // BTNcargarDG
            // 
            this.BTNcargarDG.Location = new System.Drawing.Point(15, 210);
            this.BTNcargarDG.Name = "BTNcargarDG";
            this.BTNcargarDG.Size = new System.Drawing.Size(121, 27);
            this.BTNcargarDG.TabIndex = 61;
            this.BTNcargarDG.Text = "Cargar Base de Datos";
            this.BTNcargarDG.UseVisualStyleBackColor = true;
            this.BTNcargarDG.Click += new System.EventHandler(this.BTNcargarDG_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(485, 16);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ventas Datos extendidos(relacionada con tabla clientes y productos)";
            // 
            // DGVentas
            // 
            this.DGVentas.AllowUserToAddRows = false;
            this.DGVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVentas.Location = new System.Drawing.Point(430, 51);
            this.DGVentas.Name = "DGVentas";
            this.DGVentas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGVentas.Size = new System.Drawing.Size(497, 150);
            this.DGVentas.TabIndex = 66;
            // 
            // BtnVentas
            // 
            this.BtnVentas.Location = new System.Drawing.Point(430, 210);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Size = new System.Drawing.Size(121, 27);
            this.BtnVentas.TabIndex = 68;
            this.BtnVentas.Text = "Cargar Ventas";
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // FRMVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 344);
            this.Controls.Add(this.BtnVentas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGVentas);
            this.Controls.Add(this.lbCargarPor);
            this.Controls.Add(this.DGTablaVentas);
            this.Controls.Add(this.BTNcargarDG);
            this.Name = "FRMVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.DGTablaVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCargarPor;
        private System.Windows.Forms.DataGridView DGTablaVentas;
        private System.Windows.Forms.Button BTNcargarDG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVentas;
        private System.Windows.Forms.Button BtnVentas;

    }
}