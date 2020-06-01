using System;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorPedido
    {
        //EL id debe de ser un int
        public static DataTable GetPedidosUsuarioTable(int idUsuario)
        {
            DataTable pedidos = null;

            try
            {
                //Devolver en formato string la consulta
                
                string query = String.Format(
                    "SELECT p.idPedido, i.producto, p.cantidad, i.precio" + 
                   " FROM PEDIDO p, INVENTARIO i, USUARIO u" + 
                    " WHERE p.idArticulo = i.idArticulo" + 
                    " AND p.idUsuario = u.idUsuario " +
                    $" AND u.idUsuario = {idUsuario}");
                
                pedidos = ConexionBD.EjecutarConsulta(
                    query);
            }
           catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        public static DataTable GetPedidosTable()
        {
            DataTable pedidos = null;

            try
            {
                /*pedidos = ConexionBD.EjecutarConsulta("SELECT p.idPedido, i.nombreArticulo, p.cantidad, i.precio, (i.precio * p.cantidad) AS total" +
                                            " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                                            " WHERE p.idArticulo = i.idArticulo" +
                                            " AND p.idUsuario = u.idUsuario"); */
                //Consulta de tipo string
                string query = String.Format(
                    "SELECT p.idPedido, i.producto, p.cantidad, i.precio" +
                    " FROM PEDIDO p, INVENTARIO i, USUARIO u" +
                    " WHERE p.idArticulo = i.idArticulo" +
                    " AND p.idUsuario = u.idUsuario"
                    );
                pedidos = ConexionBD.EjecutarConsulta(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return pedidos;
        }

        //Cambiando los string por int
        public static void HacerPedido(int idUsuario, int idArticulo, int cantidad)
        {
            try
            {
                //Devolver el comando en formato string
                string query = String.Format("INSERT INTO PEDIDO(idUsuario, idArticulo, cantidad) " +
                                             $"VALUES({idUsuario}, {idArticulo}, {cantidad})");
                ConexionBD.EjecutarComando(query);
            }
                
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
