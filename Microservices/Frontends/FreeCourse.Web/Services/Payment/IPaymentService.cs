using FreeCourse.Web.Models.FakePayments;

namespace FreeCourse.Web.Services.Payment
{
    public interface IPaymentService
    {
        Task<bool> ReceivePayment(PaymentInfoInput paymentInfoInput);
    }
}
