namespace PARCIAL2
{
    public class Product
    {
        public int idProduct { get; set; }
        
        public int idBusiness { get; set; }
        
        public string name { get; set; }

        public Product()
        {
            
        }

        public Product(int iIdProduct, int iIdBusiness, string nName)
        {
            idProduct = iIdProduct;
            idBusiness = iIdBusiness;
            name = nName;
        }
    }
}