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
        private string cadenaConexion;
        public BaseDatoBit()
        {
            establecerConfBD();
        }
         /*
          * Método que configura la conexión a la BD
          */
        private void establecerConfBD()
        {
            //servidor = "192.168.101.192";
            servidor = "localhost";
            nombreBD = "inventariouma";
            usuario = "root";
            password = "root";
            cadenaConexion = "SERVER=" + servidor + ";" + "DATABASE=" + nombreBD + ";" + "UID=" +
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
            catch (MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error al intentar abrir la conexion a la base de datos, por favor contacte con el administrador del sistema",
                                "Base de datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
            catch(MySqlException)
            {
                MessageBox.Show("Ha ocurrido un error alcerrar la conexion con la base de datos, por favor contacte con el administrador del sistema",
                                "Base de datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
        }

        

        public bool agregarComputadoraInventario(string ID, string folio, string categoria, string tipo, string marca, string noserie, string modelo, string ram,
                                       string tipoprocesador, string velocidadprocesador, string nodiscosduros, string capaciadHdd,string sistemaoperativo,
                                       string versionSO, string estadofisico, string precio, string resguardante,string inventario,string composicion) 
        {
            try 
            {
                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("agregar_computadora", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID", ID);
                    cmd.Parameters.AddWithValue("@folio",folio);
                    cmd.Parameters.AddWithValue("@Categoria", categoria);
                    cmd.Parameters.AddWithValue("@Tipo", tipo);
                    cmd.Parameters.AddWithValue("@Marca", marca);
                    cmd.Parameters.AddWithValue("@NoSerie", noserie);
                    cmd.Parameters.AddWithValue("@Modelo", modelo);
                    cmd.Parameters.AddWithValue("@RAM", ram);
                    cmd.Parameters.AddWithValue("@TipoProcesador", tipoprocesador);
                    cmd.Parameters.AddWithValue("@VelocidadProc", velocidadprocesador);
                    cmd.Parameters.AddWithValue("@NoDiscoDuros", nodiscosduros);
                    cmd.Parameters.AddWithValue("@CapDiscoDuro", capaciadHdd);
                    cmd.Parameters.AddWithValue("@SistemaOperativo", sistemaoperativo);
                    cmd.Parameters.AddWithValue("@VersionSO", versionSO);
                    cmd.Parameters.AddWithValue("@EstadoFisico", estadofisico);
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Resguardante", resguardante);
                    cmd.Parameters.AddWithValue("@Inventario", inventario);
                    cmd.Parameters.AddWithValue("@composicion", composicion);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                    return true;
                }
                else 
                return false;
            }catch(MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error en la Base de datos: "+ex);
                return false;
            }
            
        }
        /*
         * Agrega un nuevo equipo (teclado,nobreak,mouse,pantalla,regulador,impresora) al inventario, usa el procedimiento almacenado
         * agregarPeriferico para efectuar esta operacion.
         */
        public bool agregarPerifericoInventario(string sicipo,string folio, string categoria, string tipo, string marca, string modelo, string noserie,
            string color, string composicion, string estadoFisico, string precio, string resguardante,string area) 
        {
            try 
            {
                if (abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand("agregarPeriferico", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID",sicipo);
                    cmd.Parameters.AddWithValue("@folio", folio);
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
                Console.WriteLine("Ha ocurrido un error en la base de datos {0}",ex);
                return false;
            }
        }

        
       
        public bool agregarRegistroBitacora(string folio,string sicipo,string equipo,string marca,string modelo, string noserie,
                                            string resguardante,string area,string problema,DateTime fecha) 
        {
            try 
            {
                string query = "insert into tbl_bitacora(folioumar,sicipo,equipotipo,marca,modelo,noserie,resguardante,area,problema,fecha)"
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
                }else
                    return false;
            }catch(MySqlException ex)
            {
                MessageBox.Show("Error en la base de datos: "+ex);
                return false;
            }
            
        }
        //Metodo que obtiene un registro de la bitacora, como parametro recibe una cadena que representa el equipo 
        //en especifico a buscar, para retornarlo en un arreglo con 6 campos
        public string [] obtenerRegistroBitacora(string param) 
        {
            string []registro =  new String[8];
            string query = "select sicipo,folio,categoria,marca,modelo,noserie,resguardante,inventario from tbl_perifericos where sicipo = @parametro";
            try 
            {
                if(abrirConexion())
                {
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@parametro",param);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while(reader.Read())
                    {
                        registro[0] = Convert.ToString(reader["sicipo"]);
                        registro[1] = Convert.ToString(reader["folio"]); ;
                        registro[2] = Convert.ToString(reader["categoria"]);
                        registro[3] = Convert.ToString(reader["marca"]);
                        registro[4] = Convert.ToString(reader["modelo"]);
                        registro[5] = Convert.ToString(reader["noserie"]);
                        registro[6] = Convert.ToString(reader["resguardante"]);
                        registro[7] = Convert.ToString(reader["inventario"]);
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
                string query = "select * from tbl_bitacora order by fecha desc";
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
                Console.WriteLine(ex.ToString());
                return dt;
            }
        }

        public DataTable buscarRegistroBit(string param) 
        {
            DataTable dt = new DataTable();
            try 
            {
                string query = "select * from tbl_bitacora where folioumar like @parametro or sicipo like @parametro or noserie like @parametro";
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

        //Metodo para obtener el registro que se agregara en el reporte
        public List<String> obtenerRegistroReporte(string sicipo,string idbitacora)
        {
            List<String> equipo = new List<string>();
            try
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand("sp_reporte", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@sicipo", sicipo);
                cmd.Parameters.AddWithValue("@idbitacora",idbitacora);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        try 
                        {
                            equipo.Add(reader.GetString(i));
                        }catch(Exception ex)
                        {
                            equipo.Add("SIN DATOS");
                        }
                    }
                }

                cerrarConexion();
                return equipo;
            }
            catch (DataException ex)
            {
                Console.WriteLine("Error {0}", ex);
                return equipo;
            }
        }

        public DataTable obtenerEquiposReporte(string sicipo) 
        {
            DataTable tabla = new DataTable();
            
            try 
            {
                string query = "select * from tbl_bitacora where sicipo = @sicipo";
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.Parameters.AddWithValue("@sicipo",sicipo);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(tabla);
                cmd.ExecuteNonQuery();
                cerrarConexion();
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return tabla;
        }
        public List<String> obtenerEquipos(string parametro) 
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
            string query = "select * from tbl_perifericos where noserie like @parametro or sicipo like @parametro"
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
                string query = "delete from tbl_bitacora where idbitacora = @idBit";
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
                    string query = "Delete from tbl_perifericos where sicipo = @parametro";
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
        public bool editarPerifericoInventario(string Sicipo,string folio, string Categoria, string Tipo,string  Marca,
                          string  Modelo, string NoSerie, string Color, string  Composicion, string  EstadoFisico,
                          string Precio, string Resguardante, string Inventario) 
        {
            try 
            {
                abrirConexion();
                string query = "update tbl_perifericos set sicipo = @ID, folio = @folio, categoria = @categoria, tipo = @tipo, marca = @marca, modelo = @modelo,"
                               + "noserie = @noserie, color = @color, composicion = @composicion, estadofisico = @estadofisico, precio = @precio,"
                               + "resguardante = @resguardante, inventario = @inventario WHERE sicipo = @ID";

                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.Parameters.AddWithValue("@ID",Sicipo);
                cmd.Parameters.AddWithValue("@folio", folio);
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
                cerrarConexion();
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
                string query = "delete from tbl_periferico where sicipo = @sicipo; delete from tbl_computadora where sicipo = @sicipo";
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

        public bool editarPCInventario(string ID, string folio,string categoria, string tipo, string marca, string noserie, string modelo, string ram,
                                       string tipoprocesador, string velocidadprocesador, string nodiscosduros, string capaciadHdd,
                                       string sistemaoperativo, string versionSO, string estadofisico, string precio ,string resguardante,
                                       string inventario) 
        {
            try 
            {
                abrirConexion();
                string query = "update tbl_computadora set sicipo = @sicipo, folio = @folio, categoria = @categoria, tipo = @tipo, marca = @marca, noserie = @noserie, modelo = @modelo, "
                               +"ram = @ram, tipoprocesador = @tipoprocesador, velocidadproc = @velocidadproc, "
                               +"nodiscoduros = @nodiscoduros, capdiscoduro = @capdiscoduro, sistemaoperativo = @so, versionSO = @verSistemaOp, "
                               +"estadofisico = @estadofisico, precio = @precio, resguardante = @resguardante, inventario = @inventario WHERE sicipo = @sicipo;"
                               + "update tbl_perifericos set sicipo = @sicipo, folio = @folio, categoria = @categoria, tipo = @tipo, marca = @marca, modelo = @modelo,noserie = @noserie,"
                               +"estadofisico = @estadofisico, precio = @precio, resguardante = @resguardante, inventario = @inventario WHERE sicipo = @sicipo ";
                
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.Parameters.AddWithValue("@sicipo",ID);
                cmd.Parameters.AddWithValue("@folio", folio);
                cmd.Parameters.AddWithValue("@categoria",categoria);
                cmd.Parameters.AddWithValue("@tipo",tipo);
                cmd.Parameters.AddWithValue("@marca",marca);
                cmd.Parameters.AddWithValue("@noserie",noserie);
                cmd.Parameters.AddWithValue("@modelo",modelo);
                cmd.Parameters.AddWithValue("@ram",ram);
                cmd.Parameters.AddWithValue("@tipoprocesador",tipoprocesador);
                cmd.Parameters.AddWithValue("@velocidadproc",velocidadprocesador);
                cmd.Parameters.AddWithValue("@nodiscoduros",nodiscosduros);
                cmd.Parameters.AddWithValue("@capdiscoduro",capaciadHdd);
                cmd.Parameters.AddWithValue("@so",sistemaoperativo);
                cmd.Parameters.AddWithValue("@verSistemaOp",versionSO);
                cmd.Parameters.AddWithValue("@estadofisico",estadofisico);
                cmd.Parameters.AddWithValue("@precio",precio);
                cmd.Parameters.AddWithValue("@resguardante", resguardante);
                cmd.Parameters.AddWithValue("@inventario", inventario);
                cmd.ExecuteNonQuery();
                cerrarConexion();
                return true;
            }catch(MySqlException ex)
            {
                MessageBox.Show("ERROR: "+ex);
                return false;
            }
        }

        public DataTable busquedaAvanzadaBitacora(DateTime primeraFecha, DateTime segundaFecha) 
        {
            DataTable dt = new DataTable();
            try 
            {
                if (abrirConexion())
                {
                    string query = "select * from tbl_bitacora where fecha between @fechaUno and @fechaDos order by fecha";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@fechaUno", primeraFecha);
                    cmd.Parameters.AddWithValue("@fechaDos", segundaFecha);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(dt);
                    cmd.ExecuteNonQuery();
                }
                return dt;

            }catch(MySqlException ex)
            {
                MessageBox.Show("ERROR: "+ex);
                return dt;
            }
            
        }
        public bool editaRegistroBit(string idRegistroBit, string folio, string sicipo, string equipo, string marca,string modelo,
                                     string noserie,string resguardante, string area, string problema,string solucion, DateTime fecha,DateTime fecha2,string estado) 
        {
            try 
            {
                string query = "update tbl_bitacora set folioumar = @folio,sicipo = @sicipo,equipotipo = @equipo,marca = @marca,"
                                +"modelo = @modelo,noserie = @noserie,resguardante = @resguardante,area = @area,problema = @problema,"
                                + "solucion = @solucion,fecha = @fecha,fecha2 = @fecha2,estado = @estado where idBitacora = @idBitacora";
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
                    cmd.Parameters.AddWithValue("@solucion", solucion);
                    cmd.Parameters.AddWithValue("@fecha",fecha);
                    cmd.Parameters.AddWithValue("@fecha2", fecha2);
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

        //Seccion de codigo para la parte de exportacion a excel
        

        public DataTable obtenerDatosParaExcel(string []parametro)
        {
            DataTable tabla = new DataTable();
            string query = "";
            try 
            {
                abrirConexion();
                MySqlCommand cmd = new MySqlCommand(query,conexion);
                cmd.Parameters.AddWithValue("@parametro",parametro);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                adp.Fill(tabla);
                cmd.ExecuteNonQuery();
                cerrarConexion();
                return tabla;
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return tabla;
            }

        }

        public DataTable obtenerEquiposBajas() 
        {
            DataTable tabla = new DataTable();
            try 
            {
                if(abrirConexion())
                {
                    string query = "select * from tbl_bitacora where estado = 2";
                    MySqlCommand cmd = new MySqlCommand(query,conexion);
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(tabla);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                }
                return tabla;

            }catch(MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error durante la consulta: "+ex);
                return tabla;
            }
        }

        public DataTable buscarEquipoBajas(string parametro)
        {
            DataTable tabla = new DataTable();
            try
            {
                if (abrirConexion())
                {
                    string query = "select * from tbl_bitacora where (folioumar like @parametro or sicipo like @parametro or noserie like @parametro or marca like @parametro) and (estado = 2)";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@parametro", "%"+parametro+"%");
                    MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                    adp.Fill(tabla);
                    cmd.ExecuteNonQuery();
                    cerrarConexion();
                }
                return tabla;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ha ocurrido un error durante la consulta: " + ex);
                return tabla;
            }
        }
        public bool respaldarBD() 
        {
            return true;
        }

    }
}
