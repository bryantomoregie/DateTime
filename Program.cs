using System;

namespace DatesTime
{
    class Program
    {
        static void Main()
        {

            DateTime thisDay = DateTime.Today;
            
            Console.WriteLine("Please enter a random past date with format xx/xx/xxxx");

            string date = Console.ReadLine();
            DateTime dateEntered;
            try{
                 dateEntered = Convert.ToDateTime(date);
                     var days = (thisDay - dateEntered).TotalDays;

            if(days > 0){
                Console.WriteLine($"Total days are: {days}");
            }else{
                System.Console.WriteLine("Please enter a date from the past");
                Main();
            }
            }
            catch{
                System.Console.WriteLine("Invalid Date");
                Main();
            }
        }
    }
}

/*
I want to get a date, and return how many days ago that was.
I want to get a time and return how many hours and minutes ago that was.
*/
