﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparcial.Modelo
{
    public class Pedido
    {
        //Convertir todos los que no son string
        public int idPedido { get; }
        public int idUsuario { get; }
        public int idArticulo { get; }
        public int cantidad { get; }

        public Pedido(int idPedido, int idUsuario, int idArticulo, int cantidad)
        {
            this.idPedido = idPedido;
            this.idUsuario = idUsuario;
            this.idArticulo = idArticulo;
            this.cantidad = cantidad;
        }
    }
}
