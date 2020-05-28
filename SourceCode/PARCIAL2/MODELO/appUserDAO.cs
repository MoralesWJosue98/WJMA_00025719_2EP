using System;
using System.Collections.Generic;
using System.Data;

namespace PARCIAL2
{
    public static class appUserDAO
    {
        public static List<appUser> getLista()
        {
            string query = "SELECT * FROM APPUSER";

            DataTable dt = ConectionDB.ExecuteQuery(query);
            
            List<appUser> list = new List<appUser>();
            foreach (DataRow row in dt.Rows)
            {
                appUser au = new appUser();
                au.idUser = Convert.ToInt32(row[0].ToString());
                au.fullName = row[1].ToString();
                au.userName = row[2].ToString();
                au.password = row[3].ToString();
                au.userType = Convert.ToBoolean(row[4].ToString());
                
                list.Add(au);
            }
            return list;
        }
        
        public static void NewPassword(string usuario, string nuevaContra)
        {
            string sql = String.Format(
                "update APPUSER set password='{0}' where userName='{1}';",
                nuevaContra, usuario);
            
            ConectionDB.ExecuteNonQuery(sql);
        }

        public static void CreateUser(string name, string userName)
        {
            string query = String.Format(
                "INSERT INTO APPUSER(fullname,username,password,userType) " +
                "VALUES('{0}','{1}','{2}', false);", name, userName,name 
                );

            ConectionDB.ExecuteNonQuery(query);
        }
        
        public static void Delete(string user)
        {
            string query = String.Format(
                "DELETE FROM APPUSER WHERE userName='{0}';", user
            );
                    
            ConectionDB.ExecuteNonQuery(query);        
        }

       
        
        
    }
}