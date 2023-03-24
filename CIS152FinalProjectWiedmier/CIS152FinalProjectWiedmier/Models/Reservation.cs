using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

/***************************************************************
* Name        : Reservation
* Author      : Mandy Wiedmier
* Created      : 03/22/2023
***************************************************************/

namespace CIS152FinalProjectWiedmier.Models
{
    public class Reservation
    {
        private string _reservationName;
        private string _typeOfReservation;
        private string _dayOfTheWeek;
        private int _numOfPeople;
        private int _phoneNumber;

        // Properties
        public string ReservationName { get => _reservationName; set => _reservationName = value; }
        public string TypeOfReservation { get => _typeOfReservation; set => _typeOfReservation = value; }
        public string DayOfWeek { get => _dayOfTheWeek; set => _dayOfTheWeek = value; }
        public int NumOfPeople { get => _numOfPeople; set => _numOfPeople = value; }
        public int PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }




        public Reservation()
        {
            int ZERO = 0;
        }

        //TODO
        //
        //Name
        //
        //
        //
        //
        //.



    }
}
