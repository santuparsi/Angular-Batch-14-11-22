using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppy.PaymentAPI.Services;
using EShoppy.PaymentAPI.Entities;
namespace EShoppy.PaymentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }
        [HttpPost]
        [Route("AddPayment")]
        public IActionResult AddPayment(Payment payment)
        {
            try
            {
                paymentService.AddPayment(payment);
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
