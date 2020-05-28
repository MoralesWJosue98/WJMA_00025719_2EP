using System;
using System.Collections.Generic;
using System.Data;

namespace PARCIAL2
{
    public class BusinessDAO
    {
        public static List<Business> getLista()
        {
            string query = "SELECT * FROM BUSINESS";

            DataTable dt = ConectionDB.ExecuteQuery(query);
            
            List<Business> list = new List<Business>();
            foreach (DataRow row in dt.Rows)
            {
                Business b = new Business();
                b.idBusiness = Convert.ToInt32(row[0].ToString());
                b.name = row[1].ToString();
                b.description = row[2].ToString();
                
                list.Add(b);
            }
            return list;
        }
        
        public static void AddBusiness(string name, string description)
        {
            string query = String.Format(
                "INSERT INTO BUSINESS(name, description) " + "VALUES('{0}','{1}'); ", name, description
             
            );
            
            ConectionDB.ExecuteNonQuery(query);
        }
        
        public static void DeleteBusiness(string name){
                    string query = String.Format(
                        "DELETE FROM BUSINESS WHERE name = '{0}'; ", name
                    );
                    
                    ConectionDB.ExecuteNonQuery(query);
                }
        
       
        
    }
}