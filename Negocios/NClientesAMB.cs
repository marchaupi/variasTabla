using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//AGREGAR para usar el data table(representa una tabla de datos en memoria)
using MySql.Data.MySqlClient; //agregar para conecciones mysql
using Datos;

namespace Negocios
{
    public class NClientesAMB : Nclientes
    {
        #region // constante y variables locales
        private DClientes mybase;     
        #endregion

        #region //metodos        
        public DataTable Agregar()
        {
            this.mybase = new DClientes();
            this.mybase.consulta = "INSERT INTO Clientes(`IdCliente`, `Nombre`, `Apellido`, `DNI`, `Direccion`) VALUES (NULL, '" + this.nombre + "', '" + this.apellido + "', '" + this.dni + "', '" + this.direccion + "')";
            //EJECUTO la consulta
            return this.mybase.ejecutarconsulta();
        }
        public DataTable Modificar()
        {
            this.mybase = new DClientes(); 
            this.mybase.consulta = "UPDATE Clientes SET Nombre='" + this.nombre + "',Apellido='" + this.apellido + "',Direccion='" + this.direccion + "',DNI ='" + this.dni + "' WHERE IdCliente ='" + this.IdCliente + "'";
            return this.mybase.ejecutarconsulta();
        }
        public DataTable Eliminar()
        {
            this.mybase = new DClientes();   
            this.mybase.consulta = "DELETE FROM Clientes WHERE IdCliente ='" + this.IdCliente + "'";
            return this.mybase.ejecutarconsulta();
        }
        #endregion
    }
}
