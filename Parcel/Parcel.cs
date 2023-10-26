using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Parcel
{
    public class Parcel
    {
        protected string deliverTo;//שם הנמען

        public Parcel(string name)
        {
            deliverTo = name;
        }

        public virtual bool Deliver()
        {
            return true;
        }
    }

    public class RegisteredParcel : Parcel
    {
        private int attempts;//מספר נסיונות להעביר את החבילה
        
        public RegisteredParcel(string name) : base(name)
        {
            attempts = 0;
        }
        public override bool Deliver()
        {
            bool success = false;
            Console.WriteLine("did you pass the parcel?");
            success = bool.Parse(Console.ReadLine());
            attempts++;

            return success;
        }
    }
    public class MuchoParcel:Parcel
    {
        public MuchoParcel(string name) : base(name) { }

        public bool Delivery()
        {
            return false;
        }
    }
}
