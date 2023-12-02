using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCanRegister.Helpers
{
    internal class RegistrationValidator
    {
        public bool CanRegister (string name, int age, string email)
        {
            bool isValidAge = age >= 18;
            bool isValidEmail = email.Contains("@");
        
            return isValidAge && isValidEmail;
        }
    }
}
