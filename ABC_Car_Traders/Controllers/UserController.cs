using ABC_Car_Traders.DBContext;
using ABC_Car_Traders.Model;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ABC_Car_Traders.Controllers
{
    public class UserController
    {
        private readonly ApplicationDBContext _context;
        public UserController(ApplicationDBContext context) 
        { 
            _context = context;
        }

        //Add users 
        public void AddUser(User user)
        {
            user.createdAt = DateTime.Now;
            user.updatedAt = DateTime.Now;
            _context.User.Add(user);
            _context.SaveChanges();

        }

        //Get all users
        public List<dynamic> GetAllUsers()
        {
            return _context.User
                .Where(user => user.roleId == 2)
                .Select(user => new
                {
                    user.userId,
                    user.firstName,
                    user.email,
                    user.address,
                    user.contactNo,
                    user.nic,
                    user.status
                })
                .ToList<dynamic>();
        }

        public List<dynamic> GetUsers()
        {
            return _context.User
                .Where(user => user.deletedAt == null)
                .Select(user => new
                {
                    user.userId,
                    user.firstName,
                    user.email,
                    //user.roleId,
                    role = user.Role.role,
                    //user.createdAt,
                    //createdAt = user.createdAt.ToString("yyyy-MM-dd"),
                    createdAt = user.createdAt.HasValue
                        ? user.createdAt.Value.ToString("yyyy-MM-dd")
                        : null,
                    user.status
                })
                .ToList<dynamic>();

        }
        //Get user by id
        public User getUserById(int userId)
        {
            return _context.User.Find(userId);
        }

        public List<Role> GetAllRoles()
        {
            return _context.Role.ToList();
        }

        // update user
        public void updateUser(User user)
        {
            user.updatedAt = DateTime.Now;
            var existingUser = _context.User.Find(user.userId);
            if (existingUser != null)
            {
                existingUser.firstName = user.firstName;
                existingUser.lastName = user.lastName;
                existingUser.email = user.email;
                existingUser.address = user.address;
                existingUser.contactNo = user.contactNo;
                existingUser.nic = user.nic;
                existingUser.status = "ACT";
                existingUser.userName = user.userName;
                existingUser.password = user.password;
              //  existingUser.roleId = user.roleId;
                _context.SaveChanges();
            }

        } 
        // Function to delete users
        public void deleteUser(int userId)
        {
            var user = _context.User.Find(userId);
            if (user != null)
            {
                user.deletedAt = DateTime.Now;
                user.status = "InAct";
                _context.SaveChanges();
            }
        }

        //get all customers by email
        public List<User> GetCustomersByEmail(string email)
        {
            return _context.User
                .Where(user => user.email.Contains(email))
                .ToList();
        }

        //get all customers by status
        public List<dynamic> GetCustomersByStatus(string status)
        {
            //return _context.User
            //.Where(user => user.deletedAt == null && user.status == status)
            //.ToList<dynamic>();
            string lowerCaseStatus = status.ToLower(); 

            return _context.User
                .Where(user => user.deletedAt == null && user.status.ToLower() == lowerCaseStatus)
                .ToList<dynamic>();
        }

        // Get total no of users where role Id is 2
        public int GetTotalUsers()
        {
            try
            {
                // Get the total number of customers
                return _context.User.
                    Where(user=>user.roleId==2).Count();
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving total customers: {ex.Message}");
            }
        }

        // Function to generate customer report
        public void GenerateCustomerReport()
        {
            var userReport = GetAllUsers();

            if (userReport == null || !userReport.Any())
            {
                MessageBox.Show("No customer data available to generate the report.");
                return;
            }

            var document = new PdfDocument();
            var page = document.AddPage();
            var gfx = XGraphics.FromPdfPage(page);
            var fontTitle = new XFont("Arial", 18, XFontStyleEx.Bold);
            var fontHeader = new XFont("Arial", 12, XFontStyleEx.Bold);
            var fontRegular = new XFont("Arial", 10, XFontStyleEx.Regular);
            var headerBrush = XBrushes.White;
            var evenRowBrush = XBrushes.LightGray;
            var oddRowBrush = XBrushes.White;
            var headerBackgroundBrush = new XSolidBrush(XColor.FromArgb(0, 51, 102));
            var titleBrush = XBrushes.Black;

            // Title
            gfx.DrawString("Customer Report", fontTitle, titleBrush, new XRect(0, 0, page.Width, 50), XStringFormats.Center);

            // Table Headers
            int yPoint = 70;
            int xPoint = 20;

            double[] columnWidths = { 50, 100, 100, 60, 50, 70, 50, 70 };
            string[] headers = { "User ID", "First Name", "Last Name", "NIC", "Address", "Contact No", "Email", "Status" };

            gfx.DrawRectangle(headerBackgroundBrush, xPoint, yPoint, page.Width - 40, 20);

            for (int i = 0; i < headers.Length; i++)
            {
                gfx.DrawString(headers[i], fontHeader, headerBrush, new XRect(xPoint, yPoint, columnWidths[i], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[i];
            }

            yPoint += 20;

            // Draw Rows
            bool isEvenRow = true;
            foreach (var user in userReport)
            {
                xPoint = 20;
                var rowBrush = isEvenRow ? evenRowBrush : oddRowBrush;
                gfx.DrawRectangle(rowBrush, xPoint, yPoint, page.Width - 40, 20);

                gfx.DrawString(user.userId.ToString(), fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[0], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[0];

                gfx.DrawString(user.firstName, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[1], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[1];

                gfx.DrawString(user.lastName, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[2], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[2];

                gfx.DrawString(user.nic, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[3], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[3];

                gfx.DrawString(user.address, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[4], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[4];

                gfx.DrawString(user.contactNo, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[5], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[5];

                gfx.DrawString(user.email, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[6], 20), XStringFormats.Center);
                xPoint += (int)columnWidths[6];

                gfx.DrawString(user.status, fontRegular, XBrushes.Black, new XRect(xPoint, yPoint, columnWidths[7], 20), XStringFormats.Center);

                yPoint += 20;
                isEvenRow = !isEvenRow;

                // Add a new page if the content exceeds the page height
                if (yPoint > page.Height - 50)
                {
                    page = document.AddPage();
                    gfx = XGraphics.FromPdfPage(page);
                    yPoint = 50; // reset yPoint for new page
                }
            }

            // Save the document to the Downloads folder
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string filePath = Path.Combine(downloadsPath, "CustomerReport.pdf");
            document.Save(filePath);
            document.Close();

            MessageBox.Show($"Customer Report generated successfully! Saved to: {filePath}");
        }




    }
}
