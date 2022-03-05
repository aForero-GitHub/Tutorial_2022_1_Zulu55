namespace POOConceptsConsole
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(day, month, year);

        }

        private int CheckDay(int day, int month, int year)
        {
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }
            else if (day > 0 && day <= daysPerMonth[month])
            {
                return day;
            }
             
            throw new DayException($"Ivalid Day: {day}");
            
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            
            throw new MonthException($"Invalid Month: {month}");
 
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }

    }
}
