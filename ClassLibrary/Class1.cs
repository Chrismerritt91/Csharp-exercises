namespace ClassLibrary
{
    public class Customer
    {
        public int customerId;
        public String customerName;
    }

    public class Product {
        //fields
        public int productId;
        public string productName;
        public double cost;
        public int quantitiyInStock;
        public static int TotalNoProducts;
    }

    public class DomesticProduct: Product {
        //using a colon with the parent classes name will act almost like inheritence as long as the fields are public, protected, private protected, internal, protected internal


    }

}
