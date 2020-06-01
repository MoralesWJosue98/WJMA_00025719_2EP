using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Preparcial.Controlador
{
    public static class ControladorInventario
    {
        // Metodo encargado de devolver un DataTable con todos los elementos del inventario
        public static DataTable GetProductosTable()
        {
            DataTable productos = null;

            // Solamente la consulta y conexion a la BD van en el try, ya que lo demas no puede ocasionar excepcion
            try
            {
                //Devolver la consulta de tipo string
                string query = "SELECT * FROM INVENTARIO";
                productos = ConexionBD.EjecutarConsulta(query);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo que devuelve los productos en formato de List
        public static List<Inventario> GetProductos()
        {
            // Declaracion de lista y DataTable
            //var productos = new List<Inventario>();
            //Declarar la lista
            List<Inventario> productos = new List<Inventario>();
            DataTable dt = null;

            try
            {
                // Consulta para llenar el DataTable
                //Dar la consulta de tipo string
                string query = "SELECT * FROM INVENTARIO";
                dt = ConexionBD.EjecutarConsulta(query);

                // Por cada fila del DataTable, crear un nuevo usuario anadiendolo a la lista
                foreach(DataRow dr in dt.Rows)
                {
                    productos.Add(new Inventario
                        (
                            //Convirtiendo los enteros
                            Convert.ToInt32(dr[0].ToString()),
                            dr[1].ToString(),
                            dr[2].ToString(),
                            Convert.ToDouble(dr[3].ToString()),
                            Convert.ToInt32(dr[4].ToString())
                        )
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }

            return productos;
        }

        // Metodo para anadir productos
        //Cambiar los valores que no deberían de ser string
        public static void AnadirProducto(string nombre, string descripcion, double precio, int stock)
        {
            try
            {
                //ConexionBD.EjecutarComando("INSERT INTO INVENTARIO(nombreArticulo, descripcion, precio, stock)" +
                   // $" VALUES('{nombre}', '{descripcion}', {precio}, {stock})");
                   //Darle a la conexión una consulta de tipo string
                   string query = String.Format(
                       "INSERT INTO INVENTARIO(producto, descripcion, precio, stock)" + 
                       $" VALUES('{nombre}','{descripcion}', '{precio}',  '{stock}')");
                       
                   ConexionBD.EjecutarComando(query);    

                MessageBox.Show("Se ha agregado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        // Metodo para eliminar productos
        //Cambiando el string, debería de ser un int
        public static void EliminarProducto(int id)
        {
            try
            {
                ConexionBD.EjecutarComando($"DELETE FROM INVENTARIO WHERE idArticulo = {id}");
               

                MessageBox.Show("Se ha eliminado el producto");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            
        }

        // Metodo para actualizar stock de un producto
        // Cambiando el id, debería de ser un int, cambiando el stock, debería de ser un int
        public static void ActualizarProducto(int id, int stock)
        {
            try
            {
                ConexionBD.EjecutarComando($"UPDATE INVENTARIO SET stock = {stock} WHERE idArticulo = {id}");
               
             

                MessageBox.Show("Se ha actualizado el producto");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }
    }
}
