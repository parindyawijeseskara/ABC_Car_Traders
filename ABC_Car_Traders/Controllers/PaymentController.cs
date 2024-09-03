using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Controllers
{
    public class PaymentController
    {
        private readonly ApplicationDBContext _context;

        public PaymentController(ApplicationDBContext context)
        {
            _context = context;

        }

        public void SavePayment(Payment payment)
        {
            _context.Payment.Add(payment);
            _context.SaveChanges();

        }
    }
}
