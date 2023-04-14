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
        private string _phoneNumber;

        // Properties
        [Required(ErrorMessage = "Please enter your name.")]
        public string ReservationName { get => _reservationName; set => _reservationName = value; }
        [Required(ErrorMessage = "Please the type of reservation.")]
        public string TypeOfReservation { get => _typeOfReservation; set => _typeOfReservation = value; }
        [Required(ErrorMessage = "Please enter the reservation day.")]

        public string DayOfWeek { get => _dayOfTheWeek; set => _dayOfTheWeek = value; }
        [Required(ErrorMessage = "Please enter the number of people.")]
        [Range(1, 100, ErrorMessage = "DexNumber must be between 1 and 100.")]
        public int NumOfPeople { get => _numOfPeople; set => _numOfPeople = value; }
        [Required(ErrorMessage = "Please enter a phone number.")]
        [Phone(ErrorMessage ="Phone Number not valid.")]
        //[RegularExpression(@"^\(?([0-9]{3}\)?[-, ]?([0-9]{3})[-, ]?([0-9]{4})$", ErrorMessage = "Phone number not valid format is 'XXX-XXX-XXXX'.")]
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }




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
