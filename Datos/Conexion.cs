using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//AGREGAR para usar el data table(representa una tabla de datos en memoria)
using MySql.Data.MySqlClient; //agregar para conecciones mysql

namespace Datos
{
    public class Conexion
    {
        #region//constantes
        private const string SERVIDOR = "127.0.0.1";// localhost
        private const string PUERTO = "3306";// Puerto predeterminado para conectar
        private const string USUARIO = "root";// usuario de conexion
        private const string CLAVE = "Mar2021";// password de conexion
        private const string BASE = "prueba";//Nombre de la base de datos
        #endregion

        #region //propiedades
        private string _cadenaDeconexion;
        private string _consulta;
        private string _nombreBase;
        private string _nombreServidor;
        private string _nombrePuerto;
        private string _nombreUsuario;
        private string _nombreClave;

        public string cadenaDeconexion
        {
            get
            {
                return _cadenaDeconexion;
            }
            set
            {
                _cadenaDeconexion = value;
            }
        }
        public string consulta
        {
            get
            {
                return _consulta;
            }
            set
            {
                _consulta = value;
            }
        }
        public string nombreBase
        {
            get
            {
                return _nombreBase;
            }
            set
            {
                _nombreBase = value;
            }
        }
        public string nombreServidor
        {
            get
            {
                return _nombreServidor;
            }
            set
            {
                _nombreServidor = value;
            }
        }
        public string nombrePuerto
        {
            get
            {
                return _nombrePuerto;
            }
            set
            {
                _nombrePuerto = value;
            }
        }
        public string nombreUsuario
        {
            get
            {
                return _nombreUsuario;
            }
            set
            {
                _nombreUsuario = value;
            }
        }
        public string nombreClave
        {
            get
            {
                return _nombreClave;
            }
            set
            {
                _nombreClave = value;
            }
        }
        #endregion

        #region//constructor
        public Conexion()
        {
            //Cargo las constantes de conexion
            this.nombreServidor = SERVIDOR;
            this.nombreBase = BASE;
            this.nombrePuerto = PUERTO;
            this.nombreUsuario = USUARIO;
            this.nombreClave = CLAVE;
            this.nombreBase = BASE;
            //CARGA cadena de conecion 
            this.cadenaDeconexion = "datasource=" + this.nombreServidor + ";" + "port=" + this.nombrePuerto + ";" + "username=" + this.nombreUsuario + ";" + "password=" + this.nombreClave + ";" + "database=" + this.nombreBase;           
        }
        #endregion
    }
}
