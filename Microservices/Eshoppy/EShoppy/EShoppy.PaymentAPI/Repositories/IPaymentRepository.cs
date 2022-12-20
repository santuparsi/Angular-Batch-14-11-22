using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.PaymentAPI.Entities;
namespace EShoppy.PaymentAPI.Repositories
{
    public interface IPaymentRepository
    {
        void AddPayment(Payment payment);
    }
}
