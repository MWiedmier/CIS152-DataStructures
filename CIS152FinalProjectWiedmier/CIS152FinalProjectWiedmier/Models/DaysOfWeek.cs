using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/***************************************************************
* Name        : DaysOfWeek
* Author      : Mandy Wiedmier
* Created      : 03/22/2023
***************************************************************/

namespace CIS152FinalProjectWiedmier.Models
{
    public class DaysOfWeek
    {
        //public const int WEEK_MAX = 70;
        //public const int DAY_MAX = 10;

        public const int WEEK_MAX = 7;
        public const int DAY_MAX = 1;


        private List<Node> mondayReservations;
        private List<Node> tuesdayReservations;
        private List<Node> wednesdayReservations;
        private List<Node> thursdayReservations;
        private List<Node> fridayReservations;
        private List<Node> saturdayReservations;
        private List<Node> sundayReservations;
        private List<Node> allReservations;

        public DaysOfWeek()
        {
            mondayReservations = new List<Node>();
            tuesdayReservations = new List<Node>();
            wednesdayReservations = new List<Node>();
            thursdayReservations = new List<Node>();
            fridayReservations = new List<Node>();
            saturdayReservations = new List<Node>();
            sundayReservations = new List<Node>();
            allReservations = new List<Node>();
        }


        public void insert(Node reservation)
        {
            //Add to specific day lists and All list
            if(reservation.data.DayOfWeek.ToLower() == "monday")
            {
                if(mondayReservations.Count < DAY_MAX)
                {
                    mondayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "tuesday")
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    tuesdayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "wednesday")
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    wednesdayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "thursday")
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    thursdayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "friday")
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    fridayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "saturday")
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    saturdayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else if (reservation.data.DayOfWeek.ToLower() == "sunday")
            {
                if (mondayReservations.Count < DAY_MAX)
                {
                    sundayReservations.Add(reservation);
                    allReservations.Add(reservation);
                }
                else
                {
                    throw new ReservationFullException();
                }
            }
            else
            {
                throw new InvalidDayException();
            }
        }
    }
}
