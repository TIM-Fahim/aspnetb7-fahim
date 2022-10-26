//Leet Code

int DaysBetweenDates(string date1, string date2)
        {
            DateTime dateTime10 = Convert.ToDateTime(date1);
            DateTime dateTime20 = Convert.ToDateTime(date2);
            Console.WriteLine(dateTime10 - dateTime20);
            return 0;
        }