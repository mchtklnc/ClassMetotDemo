using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMetotDemo
{


    class Program
    {

        static void Main(string[] args)
        {
            Guest guest1 = new Guest();
            guest1.Id = 1;
            guest1.guestName = "Mücahit";
            guest1.guestSurname = "Kılınç";
            guest1.accountNumber = 21803259;
            guest1.creditType = "Evlilik Kredisi";

            Guest guest2 = new Guest();
            guest2.Id = 2;
            guest2.guestName = "Ayşenur";
            guest2.guestSurname = "Pala";
            guest2.accountNumber = 33514545;
            guest2.creditType = "Konut Kredisi";

            Guest guest3 = new Guest();
            guest3.Id = 3;
            guest3.guestName = "Baran Tunç";
            guest3.guestSurname = "Nergiz";
            guest3.accountNumber = 45102122;
            guest3.creditType = "Kobi İhtiyaç Kredisi";

            Guest guest4 = new Guest();
            guest4.Id = 4;
            guest4.guestName = "Yusuf Mert";
            guest4.guestSurname = "Avcı";
            guest4.accountNumber = 11763259;
            guest4.creditType = "Öğrenci Kredisi";

            Guest guest5 = new Guest();
            guest5.Id = 5;
            guest5.guestName = "Dilan";
            guest5.guestSurname = "Avcı";
            guest5.accountNumber = 97124326;
            guest5.creditType = "İhtiyaç Kredisi";

            Guest guest6 = new Guest();
            guest6.Id = 6;
            guest6.guestName = "Muratcan";
            guest6.guestSurname = "Batıbay";
            guest6.accountNumber = 98224552;
            guest6.creditType = "Taşıt Kredisi";

            Console.WriteLine("----- Müşteri Bilgileri -----");

            Guest[] guests = new Guest[]
            {
                guest1,guest2,guest3,
                            guest4,guest5,guest6
            };


            foreach (var guest in guests)
            {
                Console.WriteLine(guest.Id + " " + guest.guestName + " " 
                    + guest.guestSurname + " "+":"+" "
                            + guest.accountNumber + " " +":"+" "+guest.creditType);
            }




            Console.WriteLine("---- Kredi Başvuruları ----");
            Console.WriteLine("Başvurular Listelendi!");
               

                GuestManager guestManager = new GuestManager();
            guestManager.List(guest1);
            guestManager.List(guest2);
            guestManager.List(guest3);
            guestManager.List(guest4);
            guestManager.List(guest5);



            Console.WriteLine("Onaylanan Başvurular");
            Console.WriteLine("Tebrikler! Kredi Talebiniz Onaylandı.");

            guestManager.Approve(guest1);
            guestManager.Approve(guest2);
            guestManager.Approve(guest4);

            Console.WriteLine("Başvurusu Onaylanmayanlar");
            Console.WriteLine("Üzgünüz! Kredi Talebiniz Reddedildi.");

            guestManager.Reject(guest3);
            guestManager.Reject(guest5);
            guestManager.Reject(guest6);




            Console.WriteLine("Bizi Tercih ettiğiniz İçin Teşekkür Ederiz!");







        }
           



    }




}

