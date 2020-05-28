using System;

namespace PARCIAL2
{
    public class appOrder
    {
        public int idOrder { get; set; }
        
        public DateTime createDate { get; set; }
        
        public int idProduct { get; set; }
        
        public int idAddress { get; set; }

        public appOrder()
        {
            
        }

        public appOrder(int iIdOrder, DateTime cCreateDate, int iIdProduct, int iIdAddress)
        {
            idOrder = iIdOrder;
            createDate = cCreateDate;
            idProduct = iIdProduct;
            idAddress = iIdAddress;
        }
        
        
        
    }
}