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
    }
}
