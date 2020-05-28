namespace PARCIAL2
{
    public class Business
    {
        public int idBusiness { get; set; }
        
        public string name { get; set; }
        
        public string description { get; set; }

        public Business()
        {
            
        }

        public Business(int iIdBusiness, string nName, string dDescription)
        {
            idBusiness = iIdBusiness;
            name = nName;
            description = dDescription;
        }
    }
}