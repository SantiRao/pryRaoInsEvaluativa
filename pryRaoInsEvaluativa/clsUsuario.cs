using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace pryRaoInsEvaluativa
{
    internal class clsUsuario
    {

        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Username { get; set; }

        //public static bool Login(string Usuario, string Contraseña)
        //{
        //    string ArchivoUsuario = "Usuarios.txt";

        //    if (File.Exists(ArchivoUsuario))
        //    {
        //        using (StreamReader sr = new StreamReader(ArchivoUsuario))
        //        {
        //            string linea;

        //            while ((linea = sr.ReadLine()) != null)
        //            {
        //                string[] partes = linea.Split(':');

        //                if (partes.Length == 3)
        //                {
        //                    string UsuarioArchivo = partes[0];
        //                    string ContraseñaArchivo = partes[1];

        //                    if (Usuario == UsuarioArchivo && Contraseña == ContraseñaArchivo)
        //                    {
        //                        return true;
        //                    }
        //                }
        //            }
        //        }
        //    }

        //    return false;
        //}

        public static void RegistroLogin(string usuario)
        {
            StreamWriter sw = new StreamWriter("Login Inicio.txt", true);
            sw.WriteLine(usuario + " - Fecha: " + DateTime.Now);
            sw.Close();
        }

        OleDbCommand Comando;
        OleDbConnection Conexion;
        OleDbDataReader Lector;

        public string RutadeConexion;
        public string CadenaConexion;

        public string EstadoConexion = "CERRADO";

        public string InstruccionSQL = "INSERT INTO Logs" +
            "('IdUsuario', 'Contraseña', 'FechaHora', 'Categoria')" +
            "VALUES ('Prueba', 'prueba', '10/10/2023', 'prueba')";

        public clsUsuario()
        {
            RutadeConexion = @"../../BD/BDLaboratorio3.accdb";
            CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutadeConexion;
            EstadoConexion = "CERRADO";
        }

        public clsUsuario(string CadenaConexion)
        {
            RutadeConexion = @"../../BD/BDLaboratorio3.accdb";
            CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutadeConexion;
            EstadoConexion = "CERRADO";
        }


        public void ConectarBD()
        {
            try
            {
                Conexion = new OleDbConnection();
                Conexion.ConnectionString = CadenaConexion;
                Conexion.Open();
                EstadoConexion = "ABIERTO";
            }
            catch (Exception error)
            {
                EstadoConexion = error.Message;
            }
        }

        public void RegistrarLog()
        {
            try
            {
                Comando = new OleDbCommand();
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = InstruccionSQL;
                Comando.ExecuteNonQuery();
                EstadoConexion = "Registro Exitoso";
            }
            catch (Exception error)
            {
                EstadoConexion = error.Message;
            }
        }

        public bool ValidacionUsuario(string Usuario, string Contraseña)
        {

            Conexion = new OleDbConnection();

            string LeerUsuarios = "SELECT * FROM Usuarios " +
                                      "WHERE Nombre =" + Usuario + 
                                      "AND Contraseña =" + Contraseña;

            using(OleDbCommand cmd = new OleDbCommand(LeerUsuarios, Conexion)) 
            {
                Comando.Connection = Conexion;
                Comando.CommandType = System.Data.CommandType.Text;
                Comando.CommandText = LeerUsuarios;

                cmd.Parameters.AddWithValue("@Nombre", Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                int validado = (int)cmd.ExecuteScalar();

                return validado > 0;
            }
        }


        public static void CargarCombo(string RutaArchivo, int IndiceColumna, ComboBox Combo)
        {
            List<string> ValoresColumna = LeerColumna(RutaArchivo, IndiceColumna);
            Combo.Items.AddRange(ValoresColumna.ToArray());
        }

        private static List<string> LeerColumna(string RutaArchivoCSV, int IndiceColumnaCSV)
        {
            List<string> ValoresColumna = new List<string>();

            try
            {
                using (StreamReader lector = new StreamReader(RutaArchivoCSV))
                {
                    while (!lector.EndOfStream)
                    {
                        string linea = lector.ReadLine();
                        string[] columnas = linea.Split(',');

                        if (linea.Length > IndiceColumnaCSV)
                        {
                            ValoresColumna.Add(columnas[IndiceColumnaCSV]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo CSV" + ex.Message);
                throw;
            }

            return ValoresColumna;
        }
    }
}
