using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient; //agregar para conecciones mysql
using Negocios;
namespace Conexion_Capas
{
    public partial class FRMVentas : Form
    {
        #region//variables locales//instancia local de la clase
        DataTable tabla;     
        NVentas miVenta;
        #endregion
        public FRMVentas()
        {
            InitializeComponent();
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            miVenta = new NVentas();
            tabla = miVenta.ConsultarTodos() ;
            DGVentas.DataSource = tabla;// cargo el data grid con la tabla que regresa de la consulta      
        }

        private void BTNcargarDG_Click(object sender, EventArgs e)
        {
            miVenta = new NVentas();
            tabla = miVenta.Cargar();
            DGTablaVentas.DataSource = tabla;// cargo el data grid con la tabla que regresa de la consulta      
        }
        

    }
}
