using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//AGREGAR para usar el data table(representa una tabla de datos en memoria)
using MySql.Data.MySqlClient; //agregar para conecciones mysql
namespace Datos
{
    public class DVentas : Conexion
    {
          #region//Variables locales
        private MySqlDataReader dr; // proporciona leer la base de datos hacia adelante
        private MySqlConnection conexionMysql; //Representa una conexión abierta a una base de datos de SQL Server        
        #endregion
       #region//constructor
        public DVentas()
        {
            Conexion cn = new Conexion();
            //CARGA la cadena de coneccion en SQL conection
            this.conexionMysql = new MySqlConnection(cadenaDeconexion);
            //ABRE la coneccion con el servidor mssql base de datos
            this.conexionMysql.Open();
   
        }
        #endregion
        #region // Metodos
        public DataTable ejecutarconsulta()
        {
            // CREA a traves de este objeto la consulta
            DataTable tabla = new DataTable("Ventas");
            //CARGA una instancia de "instruccion o comando "para una coneccion para Mysql table
            MySqlCommand comando = new MySqlCommand(this.consulta, this.conexionMysql);
            //CONECTA con el servidor de base de datos una instancion de "instrucion o comando"
            comando.Connection = this.conexionMysql;
            //EJECUTA la instruccion o comando y carga el rfesultado en un sql datareader (dr)
            dr = comando.ExecuteReader();
            //carga el SQLdatareader en una data table
            tabla.Load(dr);
            //retorna una data table
            return tabla;
        }
        #endregion
    }
}
