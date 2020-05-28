using System;
using System.Collections.Generic;
using System.Data;

namespace PARCIAL2
{
    public static class AddressDAO
    {
        public static List<Address> getLista()
        {
            string query = "SELECT * FROM ADDRESS";

            DataTable dt = ConectionDB.ExecuteQuery(query);
            
            List<Address> list = new List<Address>();
            foreach (DataRow row in dt.Rows)
            {
                Address a = new Address();
                a.idAddress = Convert.ToInt32(row[0].ToString());
                a.idUser = Convert.ToInt32(row[1].ToString());
                a.address = row[2].ToString();

                list.Add(a);
            }
            return list;
        }
        
        public static void Address(int idUser, string address)
        {
           string query = String.Format(
           "INSERT INTO ADDRESS(idUser,address)" + "VALUES('{0}', '{1}');", idUser, address
           
           );
            ConectionDB.ExecuteNonQuery(query);
        
        }
        
        public static void DeleteAddress(int idAddress)
        {
             string query = String.Format(
             "DELETE FROM ADDRESS WHERE idAddress='{0}';", idAddress
             
             );
             
             ConectionDB.ExecuteNonQuery(query);

        }
        
        //UPDATE ADDRESS SET address = 'nueva' WHERE idAddress = 1
        
        public static void NewAddress(string newAddress, int idAddress)
        {
              string query = String.Format(
                  "UPDATE ADDRESS SET address='{0}' WHERE idaddress='{1}';", newAddress,idAddress
                  );
                  
               ConectionDB.ExecuteNonQuery(query);   
        }
        
       // SELECT ad.idAddress, ad.address FROM ADDRESS ad WHERE idUser = 1
      
       
        

    }
}