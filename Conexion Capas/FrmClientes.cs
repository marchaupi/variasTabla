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
    public partial class FrmClientes : Form
    {
        #region//variables locales//instancia local de la clase
        DataTable tabla;
        DataTable tablaDG;
        DataRow fila;//creo una variable donde guardo el registro de la tabla
        int indice = -1;
        Nclientes miCliente;
        #endregion
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                cargarTextBox();
            }
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            if ((indice < tabla.Rows.Count - 1) && (indice >= 0))
            {
                indice++;
                cargarTextBox();
                //DG1.CurrentCell  ;
                
            }
        }
        #region// Funciones
        private void cargarTextBox()
        {
       //     if (DG1.SelectedRows.Count > 0)
         //   {
                
                fila = tabla.Rows[indice];              
                txtID.Text = fila["IdCliente"].ToString();
                txtNombre.Text = fila["Nombre"].ToString();
                txtApellido.Text = fila["Apellido"].ToString();
                txtDNI.Text = fila["DNI"].ToString();
                TXTdireccion.Text = fila["Direccion"].ToString();
           // }
        }
        #endregion

        private void BtnAMB_Click(object sender, EventArgs e)
        {
            FrmAMBClientes miAMB = new FrmAMBClientes();
            miAMB.Show();
        }

        private void TXTbuscar_KeyUp(object sender, KeyEventArgs e)
        {
            string texto;
            texto = TXTbuscar.Text;
            miCliente = new Nclientes();
            tabla = miCliente.consultasNombres(texto);
            DG1.DataSource = tabla;// cargo el data grid con la tabla que regresa de la 
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {                
            miCliente = new Nclientes();
            tabla = miCliente.ConsultarTodos();
            tablaDG = miCliente.consultas();
            DG1.DataSource = tablaDG;// cargo el data grid con la tabla que regresa de la
            indice = DG1.CurrentRow.Index;
            cargarTextBox();
 
        }

        private void DG1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = DG1.CurrentRow.Index;
            cargarTextBox();

        }


    }
}
