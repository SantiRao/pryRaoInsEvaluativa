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
            string RutadeConexion = @"../../BD/BDLaboratorio3.accdb";
            string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + RutadeConexion;

            using (OleDbConnection Conexion = new OleDbConnection(CadenaConexion))
            {
                try
                {
                    Conexion.Open();

                    string LeerUsuarios = "SELECT COUNT(*) FROM Usuarios " +
                                           "WHERE Nombre = @Nombre AND Contraseña = @Contraseña";

                    using (OleDbCommand cmd = new OleDbCommand(LeerUsuarios, Conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", Contraseña);

                        int validado = (int)cmd.ExecuteScalar();

                        return validado > 0;
                    }
                }
                catch (Exception error)
                {

                    Console.WriteLine("Error en la validación de usuario: " + error.Message);
                    return false;
                }
            }
        }
        //public static void CargarCombo(string RutaArchivo, int IndiceColumna, ComboBox Combo)
        //{
        //    try
        //    {
        //        if (File.Exists(RutaArchivo))
        //        {
        //            List<string> ValoresColumna = LeerColumna(RutaArchivo, IndiceColumna);
        //            Combo.Items.AddRange(ValoresColumna.ToArray());
        //        }
        //        else
        //        {
        //            MessageBox.Show("El archivo CSV no existe en la ruta especificada.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al cargar el combo: " + ex.Message);
        //    }
        //}

        //private static List<string> LeerColumna(string RutaArchivoCSV, int IndiceColumnaCSV)
        //{
        //    List<string> ValoresColumna = new List<string>();

        //    try
        //    {
        //        using (StreamReader lector = new StreamReader(RutaArchivoCSV))
        //        {
                   
        //            lector.ReadLine();

        //            while (!lector.EndOfStream)
        //            {
        //                string linea = lector.ReadLine();
        //                string[] columnas = linea.Split(',');

        //                if (IndiceColumnaCSV >= 0 && IndiceColumnaCSV < columnas.Length)
        //                {
        //                    ValoresColumna.Add(columnas[IndiceColumnaCSV]);
        //                }
        //            }
        //        }
        //    }

        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al leer el archivo CSV: " + ex.Message);
        //    }

        //    return ValoresColumna;
        //}

        public void CargarInfo(DataGridView grilla, ComboBox cmbJuzg, ComboBox cmbJuri, ComboBox cmbLiqui)
        {
            string archivoProveedor = "../../CSV/Listado de aseguradores.csv";

            try
            {

                using (StreamReader sr = new StreamReader(archivoProveedor))
                {
                    string readLine = sr.ReadLine();
                    if (readLine != null)
                    {
                        string[] separador = readLine.Split(';');


                        HashSet<string> jurisdicciones = new HashSet<string>();
                        HashSet<string> responsables = new HashSet<string>();
                        HashSet<string> juzgados = new HashSet<string>();

                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            separador = readLine.Split(';');
                            grilla.Rows.Add(separador);

                            juzgados.Add(separador[4]);
                            jurisdicciones.Add(separador[5]);
                            responsables.Add(separador[7]);

                        }

                        foreach (string jurisdiccion in jurisdicciones)
                        {
                            cmbJuri.Items.Add(jurisdiccion);
                        }

                        foreach (string juzgado in juzgados)
                        {
                            cmbJuzg.Items.Add(juzgado);
                        }

                        foreach (string liquida in responsables)
                        {
                            cmbLiqui.Items.Add(liquida);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar el archivo: " + ex.Message, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
