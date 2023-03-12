using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class GuestManager
    {
        public void List(Guest guest)
        {
            Console.WriteLine(guest.guestName+" "
                +guest.guestSurname+" "+":"+" "+guest.creditType);
        }

            public void Approve(Guest guest)
            {
                Console.WriteLine(guest.guestName + " "
                + guest.guestSurname + " " + ":" + " " + guest.creditType);
            }


                public void Reject(Guest guest)
                {
                     Console.WriteLine(guest.guestName + " "
                     + guest.guestSurname + " " + ":" + " " + guest.creditType);
                }




     }
        
        
    
}
