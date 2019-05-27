namespace Lab4
{
    public static class Calendar
    {
        public static bool IsLeapYear(uint year)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else if (year % 100 == 0)
            {
                return false;
            }
            else if (year % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetDaysInMonth(uint year, uint month)
        {
            if (year < 10000 && month <= 12)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    return 31;
                }
                else if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    return 30;
                }
                else if (month == 2)
                {
                    if (Calendar.IsLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
            }
            return -1;
        }
    }
}
