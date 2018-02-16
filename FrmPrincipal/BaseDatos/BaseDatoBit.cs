using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
namespace Simael.BaseDatos
{
    /*
     * Autor: Jose Manuel Gomez Alavez
     * Fecha: 20 Enero 2018
     * Descripcion: Esta clase gestiona la conexion , insercion, actualizacion y eliminacion de datos del sistema en el SGBD Mysql
     */
    class BaseDatoBit
    {
        private MySqlConnection conexion;
        private string servidor;
        private string nombreBD;
        private string usuario;
        private string password;

        public BaseDatoBit()
        {
            establecerConfBD();
        }
         /*
          * Método que configura la conexión a la BD
          */
        private void establecerConfBD()
        {
            servidor = "localhost";
            nombreBD = "simael";
            usuario = "root";
            password = "";
            string cadenaConexion = "SERVER=" + servidor + ";" + "DATABASE=" + nombreBD + ";" + "UID=" +
                                     usuario + ";" + "PASSWORD=" + password + ";";
            conexion = new MySqlConnection(cadenaConexion);
        }

        private bool abrirConexion()
        {
            try
            {
                conexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error {0}",ex);
                return false;
            }
        }

        private bool cerrarConexion() 
        {
            try 
            {
                conexion.Close();
                return true;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return false;
            }
        }

        public bool agregarRegistroBitacora(string folio,string sicipo,string equipo,string marca,string modelo, string noserie,
                                            string resguardante,string area,string problema,DateTime fecha) 
        {
            try 
            {
                string query = "insert into bitacora(folioumar,sicipo,equipotipo,marca,modelo,noserie,resguardante,area,problema,fecha)"
                                   + "values(@folio,@sicipo,@equipo,@marca,@modelo,@noserie,@resguardante,@area,@problema,@fecha)";

                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@folio", folio);
                    cmd.Parameters.AddWithValue("@sicipo", sicipo);
                    cmd.Parameters.AddWithValue("@equipo", equipo);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@noserie", noserie);
                    cmd.Parameters.AddWithValue("@resguardante", resguardante);
                    cmd.Parameters.AddWithValue("@area", area);
                    cmd.Parameters.AddWithValue("@problema", problema);
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(MySqlException ex)
            {
                Console.WriteLine("Error {0}",ex);
                return false;
            }
            
        }

        public  DataTable obtenerRegistrosBit() 
        {
            DataTable dt = new DataTable();
            try 
            {
                string query = "select * from bitacora order by fecha desc";
                if (abrirConexion()) 
                {
                    MySqlCommand cmd = new MySqlCommand(query,conexion);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dt);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                }
                return dt;
            }catch(DataException ex)
            {
                return dt;
            }
        }

        public DataTable buscarRegistroBit(string param) 
        {
            DataTable dt = new DataTable();
            try 
            {
                string query = "select * from bitacora where folioumar  like @parametro or sicipo like @parametro or noserie like @parametro or marca like @parametro";
                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query,conexion);
                    cmd.Parameters.AddWithValue("@parametro","%" + param + "%");
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dt);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                }
                return dt;
            }catch(DataException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return dt;
            }
        }


        public DataTable ultimosRegistros() 
        {
            DataTable dt = new DataTable();
            string query = "select * from equipos_recientes";
            try
            {
                if(abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dt);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                }
                return dt;
            }
            catch(DataException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return dt;
            }
        }

        public bool eliminarRegistroBit(string idBit) 
        {
            try 
            {
                string query = "delete from bitacora where idbitacora = @idBit";
                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query,conexion);
                    cmd.Parameters.AddWithValue("@idBit", idBit);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
                else 
                {
                    return false;
                }
            }catch(MySqlException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return false;
            }

        }

        public bool editaRegistroBit(string idRegistroBit, string folio, string sicipo, string equipo, string marca,string modelo,
                                     string noserie,string resguardante, string area, string problema, DateTime fecha) 
        {
            try 
            {
                string query = "update bitacora set folioumar = @folio,sicipo = @sicipo,equipotipo = @equipo,marca = @marca,"
                                +"modelo = @modelo,noserie = @noserie,resguardante = @resguardante,area = @area,problema = @problema,"
                                +"fecha = @fecha where idBitacora = @idBitacora";
                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query,conexion);
                    cmd.Parameters.AddWithValue("@idBitacora",idRegistroBit);
                    cmd.Parameters.AddWithValue("@folio",folio);
                    cmd.Parameters.AddWithValue("@sicipo", sicipo);
                    cmd.Parameters.AddWithValue("@equipo", equipo);
                    cmd.Parameters.AddWithValue("@marca",marca);
                    cmd.Parameters.AddWithValue("@modelo", modelo);
                    cmd.Parameters.AddWithValue("@noserie", noserie);
                    cmd.Parameters.AddWithValue("@resguardante", resguardante);
                    cmd.Parameters.AddWithValue("@area", area);
                    cmd.Parameters.AddWithValue("@problema",problema);
                    cmd.Parameters.AddWithValue("@fecha",fecha);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
                else 
                {
                    return false;
                }
                
            }catch(MySqlException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return false;
            }

        }

    }
}
