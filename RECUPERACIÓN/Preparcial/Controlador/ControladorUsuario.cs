using System.Data;
using System.Collections.Generic;
using Preparcial.Modelo;
using System;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorUsuario
    {
        public static List<Usuario> GetUsuarios()
        {
            var usuarios = new List<Usuario>();
            DataTable tableUsuarios = null;

            try
            {
                //Devolver una consulta en formato string
                string query = String.Format("SELECT * FROM USUARIO");
                tableUsuarios = ConexionBD.EjecutarConsulta(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            foreach(DataRow dr in tableUsuarios.Rows)
            {
                usuarios.Add(new Usuario
                    (
                        //Convertir el int
                        Convert.ToInt32(dr[0].ToString()),
                        dr[1].ToString(),
                        dr[2].ToString(),
                        Convert.ToBoolean(dr[3].ToString())
                    )
                );
            }

            return usuarios;
        }

        public static DataTable GetUsuariosTable()
        {
            DataTable tableUsuarios = null;

            try
            {
                //Devolver una consulta en formato String
                string query = String.Format("SELECT * FROM USUARIO");
                tableUsuarios = ConexionBD.EjecutarConsulta(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return tableUsuarios;
        }

        //El id, debe de ser un int
        public static void ActualizarContrasena(int idUsuario, string nueva)
        {
            try
            {
                //Devolver el comando en formato string
                string query = String.Format($"UPDATE USUARIO SET contrasena = '{nueva}' " +
                                              $"WHERE idUsuario = {idUsuario}");
                ConexionBD.EjecutarComando(query);

                MessageBox.Show("Se ha actualizado la contrasena");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        public static void CrearUsuario(string usuario)
        {
            try
            {
                //Devolver un comando en formato string
                string query = String.Format("INSERT INTO USUARIO(nombreUsuario, contrasena, admin)" +
                                             $" VALUES('{usuario}', '{usuario}', false)");
                ConexionBD.EjecutarComando(query);

                MessageBox.Show("Se ha agregado el nuevo usuario, contrasenia igual al nombre");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
