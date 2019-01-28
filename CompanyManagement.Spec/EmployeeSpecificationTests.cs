using FluentAssertions;
using Xbehave;

namespace CompanyManagement.Spec
{
    public class EmployeeSpecificationTests
    {
        private Employee _employee;

        [Background]
        public void Background()
        {
            // this method is executed before the scenario, the name doesn't have to be Background
            "Given an employee"
                .x(() => _employee = new Employee());
        }

        [Scenario]
        [Example(150, 20, 30, 1500, 1800, 2400)]
        [Example(100, 0, 0, 1000, 1000, 1000)]
        [Example(50, 30, 50, 500, 950, 1950)]
        public void CalculateMonthlySalary(int hoursWorkedDuringTheWeek, int hoursWorkedOntheWeekend, int hoursWorkedOnHolidays, decimal expectedSalaryForWeekHours, decimal expectedSalaryWithWeekendHours, decimal expectedTotalSalary)
        {
            "When I add the hours worked during the week"
                .x(() => _employee.AddMonthlyHoursWorkedDuringTheWeek(hoursWorkedDuringTheWeek));

            $"Then the salary should be {expectedSalaryForWeekHours}"
                .x(() => _employee.Salary.Should().Be(expectedSalaryForWeekHours));

            "When I add the hours worked on the weekend"
                .x(() => _employee.AddMonthlyHoursWorkedOnTheWeekend(hoursWorkedOntheWeekend));

            $"Then the salary should be {expectedSalaryWithWeekendHours}"
                .x(() => _employee.Salary.Should().Be(expectedSalaryWithWeekendHours));

            "When I add the hours worked on holidays"
                .x(() => _employee.AddMonthlyHoursWorkedOnHolidays(hoursWorkedOnHolidays));

            $"Then the total salary should be {expectedTotalSalary}"
                .x(() => _employee.Salary.Should().Be(expectedTotalSalary));
        }
    }
}
