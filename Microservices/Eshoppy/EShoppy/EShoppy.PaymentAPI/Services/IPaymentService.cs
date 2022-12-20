using EShoppy.PaymentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppy.PaymentAPI.Services
{
   public interface IPaymentService
    {
        void AddPayment(Payment payment);
    }
}
