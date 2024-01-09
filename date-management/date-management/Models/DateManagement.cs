using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace date_management.Models
{
    public class DateManagement
    {
        public int GetCalendarDays(DateTime startDate, DateTime endDate) 
        {
            TimeSpan differenceBetweenStartAndEndDates = endDate - startDate;
            return differenceBetweenStartAndEndDates.Days;
        }

        public int GetWorkingDays(DateTime startDate, DateTime endDate, List<DateTime> holidays) 
        {
            int workingDays = 0;
            DateTime currentDate = startDate;

            while (currentDate <= endDate)
            {
                if (IsWorkingDay(currentDate, holidays))
                {
                    workingDays++;
                }

                currentDate = currentDate.AddDays(1);
            }

            return workingDays;
        }

        public DateTime AddWorkingDays(DateTime startDate,int workingDays, List<DateTime> holidays) 
        {
            DateTime currentDate = startDate;

            while (workingDays > 0)
            {
                currentDate = currentDate.AddDays(1);

                if (IsWorkingDay(currentDate, holidays))
                {
                    workingDays--;
                }
            }

            return currentDate;
        }

        // Check if a day is a working day, taking into account weekends and holidays.
        private static bool IsWorkingDay(DateTime date, List<DateTime> holidays)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }

            if (holidays.Contains(date))
            {
                return false;
            }

            return true;
        }
    }
}
