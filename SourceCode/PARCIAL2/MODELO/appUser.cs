namespace PARCIAL2
{
    public class appUser
    {
        public int idUser { get; set; }
        
        public string fullName { get; set; }
        
        public string userName { get; set; }
        
        public string password { get; set; }
        
        public bool userType { get; set; }

        public appUser()
        {
            
        }

        public appUser(int iIdUser, string fFullName, string uUserName, string pPassword, bool uUserType)
        {
            idUser = iIdUser;
            fullName = fFullName;
            userName = uUserName;
            password = pPassword;
            userType = uUserType;
        }
        
        
    }
}