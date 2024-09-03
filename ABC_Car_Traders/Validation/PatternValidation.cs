using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Car_Traders.Validation
{
    public class PatternValidation
    {
        //public static readonly string namePattern = @"^[A-Z][a-zA-Z\s]*$"; // Names should start with a capital letter and contain only letters and spaces
        public static readonly string namePattern = @"^[A-Z][a-zA-Zà-ÿÀ-ß'\-\s]*$";
        public static readonly string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // email pattern
        public static readonly string contactNoPattern = @"^\d{10}$"; //10-digit phone number
        public static readonly string nicPattern = @"^[0-9]{9}[Vv]$"; // NIC pattern for Sri Lanka
        public static readonly string userNamePattern = @"^[a-zA-Z0-9_]{3,16}$"; // Alphanumeric username with underscores, 3-16 characters
        public static readonly string passwordPattern = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"; // Minimum 8 characters, at least one letter and one number
        public static readonly string addressPattern = @"^[\d\w\s,.#-]+$";

        public static readonly string regNoPattern = @"^[A-Z0-9- ]+$";  // Alphanumeric with optional dashes and spaces
        public static readonly string imagePattern = @"\.(jpg|jpeg|png|gif)$";  // Image file extensions

    }
}
