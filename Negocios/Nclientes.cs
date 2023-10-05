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
    public class Nclientes
    {
        #region // constante y variables locales
        private DClientes mybase;
        DataTable tabla; 
        string sql = "";
        #endregion
        #region //propiedades
        private string _nombre = "";
        private string _apellido = "";
        private string _dni = "";
        private string _direccion = "";
        private string _IdCliente = "";
        public string direccion
        {
            get
            {
                return _direccion;
            }
            set
            {
                _direccion = value;
            }
        }

        public string nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                _nombre = value;
            }
        }

        public string apellido
        {
            get
            {
                return _apellido;

            }
            set
            {
                _apellido = value;
            }
        }

        public string dni
        {
            get
            {
                return _dni;
            }
            set
            {
                _dni = value;
            }
        }
        public string IdCliente
        {
            get
            {
                return _IdCliente;
            }
            set
            {
                _IdCliente = value;
            }
        }
        #endregion
        #region //metodos
        public DataTable ConsultarTodos()
        {
            //INSTANCIO la clase
            this.mybase = new DClientes();
            //CARGO la consulta
            this.mybase.consulta = "Select * from Clientes";
            //EJECUTO la consulta
            return this.mybase.ejecutarconsulta();
        }
        public DataTable consultas()
        {
            this.mybase = new DClientes();            
            sql = "select Nombre,Apellido,Direccion from Clientes";            
            mybase.consulta = sql;
            tabla = mybase.ejecutarconsulta();
            return tabla;
        }
        public DataTable consultasTodos()
        {
            this.mybase = new DClientes();
            sql = "select * from Clientes";
            mybase.consulta = sql;
            tabla = mybase.ejecutarconsulta();
            return tabla;
        }
        public DataTable consultasNombres(string texto)
        {
            this.mybase = new DClientes();
            if (texto != "")
            {
                sql = sql = "select * from Clientes  WHERE Nombre like'" + texto + "%'";
            }
            else
            {
                sql = "select * from Clientes";
            }
            mybase.consulta = sql;
            tabla = mybase.ejecutarconsulta();
            return tabla;
        }

 
       
        #endregion
    }
}
