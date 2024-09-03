using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Controllers
{
    public class OrdersController
    {
        private readonly ApplicationDBContext _context;

        public OrdersController(ApplicationDBContext context)
        {
            _context = context;

        }

        /*** --------------------Save Oreder ------------------------- ***/
        public void SaveOrder(Order order)
        {
            _context.Order.Add(order);
            _context.SaveChanges();

        }

        /*** --------------------Save Oreder Details------------------------- ***/
        public void SaveOrderDetails(OrderDetail orderDetail)
        {

            _context.OrderDetail.Add(orderDetail);
            _context.SaveChanges();

        }

        /*** --------------------Get All Orders by Id------------------------- ***/
        public List<dynamic> GetAllOrdersById(int id)
        {
            return _context.OrderDetail
                .Where(orderdetail => orderdetail.orderId == id)
                .Select(orderdetail => new
                {
                    orderdetail.Car,
                    orderdetail.qty,
                    orderdetail.created_at,
                    orderdetail.unitPrice,
                    orderdetail.Order
                })
                .ToList<dynamic>();
        }

        /*** --------------------Get All Orders------------------------- ***/
        public List<dynamic> GetAllOrders()
        {
            return _context.OrderDetail
                .Select(orderdetail => new
                {
                    orderdetail.Car,
                    orderdetail.qty,
                    orderdetail.created_at,
                    orderdetail.unitPrice,
                    orderdetail.Order,
                    orderdetail.Order.orderDate,
                    orderdetail.Car.regNo,
                    orderdetail.Order.orderId,
                    orderdetail.Order.User.nic,
                    orderdetail.Order.User.firstName,
                    orderdetail.Car.Model.modelName,
                    orderdetail.status,
                    orderdetail.Order.total
                })
                .ToList<dynamic>();
        }

        public int GetTotalCarOrders()
        {
            try
            {
                // Count the number of OrderDetails that have a non-null carId
                return _context.OrderDetail.Count(od => od.carId != null);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving total car orders: {ex.Message}");
            }
        }

        public int GetTotalCarPartOrders()
        {
            try
            {
                // Count the number of OrderDetails that have a non-null CarPartsId
                return _context.OrderDetail.Count(od => od.CarPartsId != null);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving total car part orders: {ex.Message}");
            }
        }


        /*** --------------------Email Send------------------------- ***/
        public void btnSendEmail_Click()
        {
            try
            {
                // Set up the email details
                string fromAddress = "parindyawijesekara@gmail.com";
                string toAddress = "parindyawijesekara@gmail.com";
                string subject = "Test Email";
                string body = "This is a test email sent from a C# .NET desktop application.";

                // Create a new MailMessage
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromAddress);
                mail.To.Add(toAddress);
                mail.Subject = subject;
                mail.Body = body;

                // Retrieve credentials from environment variables
                string email = Environment.GetEnvironmentVariable("EMAIL_ADDRESS");
                string password = Environment.GetEnvironmentVariable("EMAIL_PASSWORD");

                // Set up the SMTP client
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(email, password),
                    EnableSsl = true
                };

                // Send the email
                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SmtpException ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
