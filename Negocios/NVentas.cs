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
   public  class NVentas
    {
        #region // constante y variables locales
        private DVentas mybase;         
        #endregion
        #region //propiedades
     
        #endregion
        #region //metodos
        public DataTable ConsultarTodos()
        {
            //INSTANCIO la clase
            this.mybase = new DVentas();
            //CARGO la consulta
            this.mybase.consulta = "SELECT V.Fecha, V.IdVentas, C.Apellido, C.Nombre, P.Producto, P.Precio FROM Ventas V, Clientes C, Productos P WHERE V.idCliente = C.idCliente AND V.IdProductos = P.IdProductos";
            //EJECUTO la consulta
            return this.mybase.ejecutarconsulta();
        }
        public DataTable Cargar()
        {
            //INSTANCIO la clase
            this.mybase = new DVentas();
            //CARGO la consulta
            this.mybase.consulta = "SELECT * from Ventas ";
            //EJECUTO la consulta
            return this.mybase.ejecutarconsulta();
        }     
        #endregion
    }
}
