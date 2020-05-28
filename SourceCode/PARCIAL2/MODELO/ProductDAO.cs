using System;
using System.Collections.Generic;
using System.Data;

namespace PARCIAL2
{
    public static class ProductDAO
    {
        public static List<Product> getLista()
        {
            string query = "SELECT * FROM PRODUCT";

            DataTable dt = ConectionDB.ExecuteQuery(query);
            
            List<Product> list = new List<Product>();
            foreach (DataRow row in dt.Rows)
            {
                
                Product p = new Product();
                p.idProduct = Convert.ToInt32(row[0].ToString());
                p.idBusiness = Convert.ToInt32(row[1].ToString());
                p.name = row[2].ToString();
                
                list.Add(p);
            }
            return list;
        }
        
        public static void AddProduct(int idBusiness, string name)
        {
            string query = String.Format(
                "INSERT INTO PRODUCT(idBusiness,name) " + "VALUES('{0}','{1}'); ", idBusiness, name
            
            );

            ConectionDB.ExecuteNonQuery(query);
        }

        public static void DeleteProduct(int idProduct)
        {
            string query = String.Format(
                 "DELETE FROM PRODUCT WHERE idProduct='{0}'; ", idProduct
            
            );
            
            ConectionDB.ExecuteNonQuery(query);
            
        }
        
       
       
        
        
        
        
    }
}