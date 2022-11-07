using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class UsuarioDAL
    {
        public static int CrearCuentas(string pUsuario, string pContraseña)
        {
            int resultado = 0;
            SqlConnection Conn = BDComun.ObtenerCOnexion();
            SqlCommand Comando = new SqlCommand(string.Format("INSERT INTO Usuarios (Nombre, Contraseña) VALUES ('{0}', PwdEncrypt('{1}'))", pUsuario, pContraseña), Conn);
            resultado = Comando.ExecuteNonQuery();
            Conn.Close();
            return resultado;
        }

        public static int Autenticar(string pUsuarios, string pContraseña)
        {
            int resultado = -1;
            SqlConnection conexion = BDComun.ObtenerCOnexion();
            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM Usuarios WHERE Nombre = '{0}' AND PwdCompare('{1}', Contraseña) = 1", pUsuarios, pContraseña), conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 200;
            }
            conexion.Close();
            return resultado;
        }
    }
}
