using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace pryRaoInsEvaluativa
{
    internal class clsUsuario
    {

        public string Usuario {get;set;}
        public string Contraseña {get;set;}
        public string Username { get;set;}

        public static bool Login (string Usuario, string Contraseña)
        {
            string ArchivoUsuario = "Usuarios.txt";

            if (File.Exists(ArchivoUsuario))
            {
                using (StreamReader sr = new StreamReader(ArchivoUsuario))
                {
                    string linea;

                    while ((linea = sr.ReadLine()) != null )
                    {
                        string[] partes = linea.Split(':');

                        if (partes.Length == 3)
                        {
                            string UsuarioArchivo = partes[0];
                            string ContraseñaArchivo = partes[1];

                            if (Usuario == UsuarioArchivo && Contraseña == ContraseñaArchivo)
                            {
                                return true;
                            }
                        }
                    }
                }
            }

            return false;
        }

        public static void RegistroLogin(string usuario)
        {
            StreamWriter sw = new StreamWriter("login Inicio.txt", true);
            sw.WriteLine(usuario + " - Fecha: " + DateTime.Now);
            sw.Close();
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
