using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingMethodsArraysLists_Exersize_App
{
    public class Email
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            return MailAddress.TryCreate(email, out _);
        }
    }

}
