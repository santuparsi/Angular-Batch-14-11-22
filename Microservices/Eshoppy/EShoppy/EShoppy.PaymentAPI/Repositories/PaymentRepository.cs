using EShoppy.PaymentAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.PaymentAPI.DBContext;

namespace EShoppy.PaymentAPI.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly EShoppyDBContext context;

        public PaymentRepository(EShoppyDBContext context)
        {
            this.context = context;
        }

        public void AddPayment(Payment payment)
        {
            try
            {
                context.Payments.Add(payment);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
