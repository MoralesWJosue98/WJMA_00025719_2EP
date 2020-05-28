namespace PARCIAL2
{
    public class Address
    {
        public int idAddress { get; set; }
        
        public int idUser { get; set; }
        
        public string address { get; set; }

        public Address()
        {
        }

        public Address(int iIdAddress, int iIdUser, string aAddress)
        {
            idAddress = iIdAddress;
            idUser = iIdUser;
            address = aAddress;
        }
        

    }
}