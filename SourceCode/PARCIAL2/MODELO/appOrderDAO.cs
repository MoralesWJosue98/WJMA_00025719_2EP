using System;
using System.Collections.Generic;
using System.Data;

namespace PARCIAL2
{
    public static class appOrderDAO
    {
        public static List<appOrder> getLista()
        {
            string query = "SELECT * FROM APPORDER";

            DataTable dt = ConectionDB.ExecuteQuery(query);
            
            List<appOrder> list = new List<appOrder>();
            foreach (DataRow row in dt.Rows)
            {
                appOrder ap = new appOrder();
                ap.idOrder = Convert.ToInt32(row[0].ToString());
                ap.createDate = Convert.ToDateTime(row[1].ToString());
                ap.idProduct = Convert.ToInt32(row[2].ToString());
                ap.idAddress = Convert.ToInt32(row[3].ToString());

                list.Add(ap);
            }
            return list;
        }
        
        public static void AddOrder(DateTime order, int idProduct, int idAddress)
        {
            string query = String.Format(
                "INSERT INTO APPORDER(createDate,idProduct,idAddress) " + "VALUES('{0}','{1}','{2}');", order, idProduct, idAddress
            
            );
            ConectionDB.ExecuteNonQuery(query);
        }
        
        public static void EliminateOrder(int id){
            string query = String.Format(
                "DELETE FROM APPORDER WHERE idOrder = '{0}';", id
            
            
            );
            
            ConectionDB.ExecuteNonQuery(query);
        
        
        }
        

    }
}