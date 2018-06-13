using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
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
            nombreBD = "inventarioumar";
            usuario = "root";
            password = "root";
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

        public bool agregarPerifericoInventario(string sicipo, string categoria, string tipo, string marca, string modelo, string noserie,
            string color, string composicion, string estadoFisico, string precio, string resguardante,string area) 
        {
            try 
            {
                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("agregarPeriferico", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID",sicipo);
                    cmd.Parameters.AddWithValue("@Categoria", categoria);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Marca", marca);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@NoSerie", noserie);
                    cmd.Parameters.AddWithValue("@Color", color);
                    cmd.Parameters.AddWithValue("@Composicion", composicion);
                    cmd.Parameters.AddWithValue("@EstadoFisico", estadoFisico);
                    cmd.Parameters.AddWithValue("@precio",precio);
                    cmd.Parameters.AddWithValue("@resguardante", resguardante);
                    cmd.Parameters.AddWithValue("@Inventario", area);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
                else
                    return false;
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Error {0}",ex);
                return false;
            }
        }

        private bool eliminarRegistroInventario(string parametro) 
        {
            try 
            {
                if (abrirConexion())
                {
                    string query = "delete from inventario";
                    return true;
                }
                else
                    return false;
                
            }
            catch(Exception ex)
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

        public string [] obtenerRegistroBitacora(string param) 
        {
            string []registro =  new String[6];
            string query = "select id,categoria,marca,modelo,noserie,resguardante from perifericos where inventario like @parametro";
            try 
            {
                if(abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@parametro", "%" + param + "%");
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        registro[0] = Convert.ToString(reader["id"]);
                        registro[1] = Convert.ToString(reader["categoria"]);
                        registro[2] = Convert.ToString(reader["marca"]);
                        registro[3] = Convert.ToString(reader["modelo"]);
                        registro[4] = Convert.ToString(reader["noserie"]);
                        registro[5] = Convert.ToString(reader["resguardante"]);
                    }
                    cerrarConexion();
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine("Ha ocurrido el siguient error {0}",ex);
            }
            return registro;
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
                string query = "select * from bitacora where folioumar like @parametro or sicipo like @parametro or noserie like @parametro";
                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query,conexion);
                    cmd.Parameters.AddWithValue("@parametro","%" + param + "%");
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dt);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                    //MessageBox.Show("Se vuelve a ejecutar");
                }
                return dt;
            }catch(DataException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return dt;
            }
        }

        //Metodo para obtener el registro que se agregara en el reporte
        public List<String> obtenerRegistroReporte(string parametro) 
        {
            List<String> equipo = new List<string>();
            try 
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("Equipo",conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@parametro",parametro);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount;i++)
                    {
                        equipo.Add(reader.GetString(i));
                    }
                }

                cerrarConexion();
                return equipo;
            }
            catch(DataException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return equipo;
            }
            
        }
        public DataTable todoRegistrosPerifericos() 
        {
            DataTable dt = new DataTable();
            string query = "select * from perifericos limit 50";
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

        //Este metodo genera la busquedad de los equipos de computo, desde el formulario buscar
        public DataTable registrosPerifericos(string param)
        {
            DataTable dt = new DataTable();
            string query = "select * from perifericos where noserie like @parametro or ID like @parametro"
                            + " or inventario like @parametro or Resguardante like @parametro";
            try
            {
                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@parametro", "%" + param + "%");
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(dt);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                }
                return dt;
            }
            catch (DataException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return dt;
            }
        }

        public DataTable busquedaAvanzada(string categoria, string palabra) 
        {
            DataTable table = new DataTable();
            string query = "select * from perifericos where "+categoria+" like @palabra";
            
            try 
            {
                if(abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query,conexion);
                   // cmd.Parameters.AddWithValue("@categoria", categoria);
                    cmd.Parameters.AddWithValue("@palabra", "%" + palabra + "%");
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    adap.Fill(table);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                }
                return table;
            }
            catch(DataException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return table;
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

        //Metodo para eliminar los equipos registrados en la tabla perifericos, la llamada se produce desde el modulo de busqueda.
        public Boolean eliminarPerifericoInventario(string parametro) 
        {
            try 
            {
                if (abrirConexion()) 
                {
                    string query = "Delete from perifericos where ID = @parametro";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@parametro", parametro);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                }
              
                return true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error durante la ejecucion de la consulta "+ex, "Consulta de datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }


        //Metodo para actualizar los datos de los equipos de la tabla perifericos desde el modulo de busqueda.
        public bool editarPerifericoInventario(string Sicipo, string Categoria, string Tipo,string  Marca,
                          string  Modelo, string NoSerie, string Color, string  Composicion, string  EstadoFisico,
                          string Precio, string Resguardante, string Inventario) 
        {
            try 
            {
                string query = "update perifericos set ID = @ID, categoria = @categoria, tipo = @tipo, marca = @marca, modelo = @modelo,"
                               + "noserie = @noserie, color = @color, composicion = @composicion, estadofisico = @estadofisico, precio = @precio,"
                               + "resguardante = @resguardante, inventario = @inventario";

                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.Parameters.AddWithValue("@ID",Sicipo);
                cmd.Parameters.AddWithValue("@categoria", Categoria);
                cmd.Parameters.AddWithValue("@tipo", Tipo);
                cmd.Parameters.AddWithValue("@marca", Marca);
                cmd.Parameters.AddWithValue("@modelo", Modelo);
                cmd.Parameters.AddWithValue("@noserie", NoSerie);
                cmd.Parameters.AddWithValue("@color", Color);
                cmd.Parameters.AddWithValue("@composicion", Composicion);
                cmd.Parameters.AddWithValue("@estadofisico", EstadoFisico);
                cmd.Parameters.AddWithValue("@precio", Precio);
                cmd.Parameters.AddWithValue("@resguardante", Resguardante);
                cmd.Parameters.AddWithValue("@inventario", Inventario);
                cmd.ExecuteNonQuery();
                
                return true;

            }catch(MySqlException ex)
            {
                return false;
            }

         }

        // Método para eliminar los equipos registrados en la tabla computadoras y en la tabla perifericos, el equipo eliminado es el mismo
        // registrado en ambas tablas, los equipos eliminados pertenecen a la categoria computadora
        public bool eliminarPCInventario(string sicipo) 
        {
            try 
            {
                string query = "delete from periferico where ID = @sicipo; delete from computadora where ID = @sicipo";
                MySqlCommand cmd = new MySqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@sicipo",sicipo);
                cmd.ExecuteNonQuery();
                
                return true;
            }catch(MySqlException ex)
            {
                return false;
            }
        }

        // Método para editar los datos de los equipos de computo registrados en las tablas computadoras y perifericos, estos equipos son los
        //mismos en ambas tablas

        public bool editarPCInventario(string ID, string categoria, string tipo, string marca, string noserie, string modelo, string ram,
                                       string noprocesadores, string tipoprocesador, string velocidadprocesador, string nodiscosduros, string capaciadHdd,
                                       string sistemaoperativo, string versionSO, string estadofisico, string precio ,string resguardante,
                                       string inventario) 
        {
            try 
            {
                string query = "update pc set ID = @sicipo, categoria = @categoria, tipo = @tipo, marca = @marca, noserie = @noserie, modelo = @modelo, "
                               +"ram = @ram, noprocesadores = @norpocesadores, tipoprocesador = @tipoprocesador, velocidadproc = @velocidadproc, "
                               +"nodiscoduros = @nodiscoduros, capdiscoduro = @capdiscoduro, sistemaoperativo = @so, versionSO = @verSitemaOp, "
                               +"estadofisico = @estadofisico, precio = @precio, resguardante = @resguardante, inventario = @inventario";

                return true;
            }catch(MySqlException ex)
            {
                return false;
            }
        }
        public bool editaRegistroBit(string idRegistroBit, string folio, string sicipo, string equipo, string marca,string modelo,
                                     string noserie,string resguardante, string area, string problema, DateTime fecha,string estado) 
        {
            try 
            {
                string query = "update bitacora set folioumar = @folio,sicipo = @sicipo,equipotipo = @equipo,marca = @marca,"
                                +"modelo = @modelo,noserie = @noserie,resguardante = @resguardante,area = @area,problema = @problema,"
                                + "fecha = @fecha,estado = @estado where idBitacora = @idBitacora";
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
                    cmd.Parameters.AddWithValue("@estado",estado);
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
