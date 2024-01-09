using date_management.Models;

DateTime startDate = new DateTime(2024, 1, 1);
DateTime endDate = new DateTime(2024, 1, 15);

DateManagement dateManagement = new DateManagement();

Console.WriteLine($"Days between '{startDate}' and '{endDate}' is {dateManagement.GetCalendarDays(startDate, endDate)} days.");

List<DateTime> holidays = new List<DateTime>
{
    new DateTime(2024, 1, 4),
    new DateTime(2024, 1, 10) 
};

Console.WriteLine($"Working days between '{startDate}' and '{endDate}' is {dateManagement.GetWorkingDays(startDate, endDate, holidays)} days.");

int workingDaysToAdd = 5;
DateTime newDate = dateManagement.AddWorkingDays(startDate, workingDaysToAdd, holidays);

Console.WriteLine($"New date adding '{workingDaysToAdd}' working days to '{startDate}' is: {newDate}");
