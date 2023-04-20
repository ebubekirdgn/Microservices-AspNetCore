using FreeCourse.Web.Models.Orders;

namespace FreeCourse.Web.Services.Order
{
    public interface IOrderService
    {
        /// <summary>
        /// Senkron iletişim- direk order mikroservisine istek yapılacak
        /// </summary>
        /// <param name="checkoutInfoInput"></param>
        /// <returns></returns>
        Task<OrderCreatedViewModel> CreateOrder(CheckoutInfoInput checkoutInfoInput);
         
        /// <summary>
        /// Asenkron iletişim- sipariş bilgileri rabbitMQ'ya gönderilecek
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        Task<OrderSuspendViewModel> SuspendOrder(CheckoutInfoInput checkoutInfoInput);


        /// <summary>
        /// Tüm siparişleri almak için
        /// </summary>
        /// <returns></returns>
        Task<List<OrderViewModel>> GetOrder(); 
    }
}
