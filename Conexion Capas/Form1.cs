using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //agregar para conecciones mysql
using Negocios;
using Microsoft.Reporting.WinForms;
namespace Conexion_Capas
{
    public partial class FRMprincipal : Form
    {
        #region//variables locales//instancia local de la clase

        #endregion
        public FRMprincipal()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes micliente = new FrmClientes();
           micliente.Show();
        }

        private void BtnAMB_Click(object sender, EventArgs e)
        {
            FrmAMBClientes miAMB = new FrmAMBClientes();
            miAMB.Show();
        }

        private void BTNVentas_Click(object sender, EventArgs e)
        {
            FRMVentas frm = new FRMVentas();
            frm.Show();
        }       


    }
}
