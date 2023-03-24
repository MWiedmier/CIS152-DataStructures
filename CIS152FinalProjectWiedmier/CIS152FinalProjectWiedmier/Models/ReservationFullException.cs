using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIS152FinalProjectWiedmier.Models
{
    public class ReservationFullException : Exception
    {
        public override string Message
        {
            get
            {
                return "Reservations are full.";
            }
        }
    }
}