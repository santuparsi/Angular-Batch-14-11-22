using EShoppy.PaymentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.PaymentAPI.Repositories;
namespace EShoppy.PaymentAPI.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository repository;

        public PaymentService(IPaymentRepository repository)
        {
            this.repository = repository;
        }

        public void AddPayment(Payment payment)
        {
            try
            {
                repository.AddPayment(payment);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
