using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class User
    {
        public delegate void VerifyEmailEventHandler(object source, EventArgs args);
        public event VerifyEmailEventHandler EmailVerified;
        protected virtual void OnEmailVerified()
        {
            if (EmailVerified != null)
            {
                EmailVerified(this, EventArgs.Empty);
            }
        }
        public void OnEmailSent()
        {
            Console.WriteLine("¿Desea verificar su correo? si/no");
            string option = Console.ReadLine();
            if(option == "si")
            {
                OnEmailVerified();
            }
        }
    }
}
