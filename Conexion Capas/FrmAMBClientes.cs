using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace Conexion_Capas
{
    public partial class FrmAMBClientes : Form
    {
        #region //Variables locales
        string amb = ""; // variable que me indica que boton presiono A-agregar;M-modificar;B-eliminar
        DataTable tabla;
        DataRow fila;//creo una variable donde guardo el registro de la tabla
        int indice = -1;

        NClientesAMB miAMBCliente; 
        #endregion
        public FrmAMBClientes()
        {
            InitializeComponent();
        }
        #region //funciones
        void limpiar()
        {
            TXTid.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            TXTdireccion.Text = "";
        }
        void activarText()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDNI.Enabled = true;
            TXTdireccion.Enabled = true;
        }
        void desactivarText()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDNI.Enabled = false;
            TXTdireccion.Enabled = false;
        }
        void activarBotones()
        {
            BTNaceptar.Enabled = true;
            BTNcancelar.Enabled = true;
            BTNagregar.Enabled = false;
            BTNmodificar.Enabled = false;
            BTNeliminar.Enabled = false;
        }
        void desactivarBotones()
        {
            TXTbuscar.Enabled = false;
            BTNcargar.Enabled = false;
            BTNaceptar.Enabled = false;
            BTNcancelar.Enabled = false;
            BTNagregar.Enabled = true;
            BTNmodificar.Enabled = true;
            BTNeliminar.Enabled = true;
        }
        void consultar()
        {
           // string consulta = "";
            miAMBCliente = new NClientesAMB();
            tabla = miAMBCliente.consultasTodos();
            DG1.DataSource = tabla;// cargo el data grid con la tabla que regresa de la consulta  
        }
        #endregion

        private void BTNagregar_Click(object sender, EventArgs e)
        {
            amb = "A";
            limpiar();
            activarText();
            txtNombre.Focus();
            activarBotones();    
        }

        private void BTNmodificar_Click(object sender, EventArgs e)
        {
            amb = "M";
            activarText();
            limpiar();
            consultar();
            TXTbuscar.Enabled = true;
            TXTbuscar.Focus();
            BTNcargar.Enabled = true;
            activarBotones();  
        }

        private void BTNeliminar_Click(object sender, EventArgs e)
        {
            amb = "E";
            consultar();
            TXTbuscar.Enabled = true;
            TXTbuscar.Focus();
            BTNcargar.Enabled = true;
            activarBotones(); 
        }

        private void BTNaceptar_Click(object sender, EventArgs e)
        {
            miAMBCliente = new NClientesAMB();
            switch (amb)
            {
                case "A":
                    miAMBCliente.apellido = txtApellido.Text;
                    miAMBCliente.nombre = txtNombre.Text;
                    miAMBCliente.dni = txtDNI.Text;
                    miAMBCliente.direccion = TXTdireccion.Text;
                    miAMBCliente.Agregar();
                    break;
                case "M":
                    miAMBCliente.apellido = txtApellido.Text;
                    miAMBCliente.nombre = txtNombre.Text;
                    miAMBCliente.dni = txtDNI.Text;
                    miAMBCliente.direccion = TXTdireccion.Text;
                    miAMBCliente.IdCliente = TXTid.Text;
                    miAMBCliente.Modificar();
                    break;
                case "E":
                    miAMBCliente.IdCliente = TXTid.Text;
                    miAMBCliente.Eliminar();
                    limpiar();
                    break;
            }
            desactivarText();
            desactivarBotones();
            consultar();
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            desactivarText();
            desactivarBotones();
        }

        private void BTNcargar_Click(object sender, EventArgs e)
        {
            if (DG1.SelectedRows.Count > 0)
            {
                indice = DG1.CurrentRow.Index;
                fila = tabla.Rows[indice];
                TXTid.Text = fila["IdCliente"].ToString();
                txtNombre.Text = fila["Nombre"].ToString();
                txtApellido.Text = fila["Apellido"].ToString();
                txtDNI.Text = fila["DNI"].ToString();
                TXTdireccion.Text = fila["Direccion"].ToString();
            }

        }

        private void TXTbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string texto;
            texto = TXTbuscar.Text;
            miAMBCliente = new NClientesAMB();
            tabla = miAMBCliente.consultasNombres(texto);
            DG1.DataSource = tabla; 
        }
    }
}
