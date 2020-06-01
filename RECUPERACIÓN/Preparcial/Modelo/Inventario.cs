using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Inventario
    {
        
        //Cambiando los valores que NO deberían de ser String
        int idArticulo { get;  }
        string producto { get; }
        string descripcion { get; }
        double precio { get; }
        int stock { get; }

        public Inventario(int idArticulo, string producto, string descripcion, double precio, int stock)
        {
            this.idArticulo = idArticulo;
            this.producto = producto;
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;
        }
    }
}
