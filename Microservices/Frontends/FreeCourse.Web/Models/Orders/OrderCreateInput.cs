namespace FreeCourse.Web.Models.Orders
{
    public class OrderCreateInput
    {
        public OrderCreateInput()
        {
            //Boş bir liste örneği oluşturduk.
            OrderItems = new List<OrderItemCreateInput>();
        }
        public string BuyerId { get; set; }
        public List<OrderItemCreateInput> OrderItems { get; set; }
        public AddressCreateInput Address { get; set; }
    } 
}
