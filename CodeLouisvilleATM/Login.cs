using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleATM
{
    public class Login
    {

    public string Username { get; set; }

        public int Pin { get; set; }

        public Login(string username, int pin)
            {
                Username = username;

                Pin = pin;
            }
        }   
}
