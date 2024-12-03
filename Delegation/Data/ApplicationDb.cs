using Delegation.Model;

namespace Delegation.Data;

public class ApplicationDb
{
    public Employee[] Employees { get; } = new Employee[100];

    public ApplicationDb()
    {
        FillEmployeeList();
    }

    private void FillEmployeeList()
    {
        int employeeCount = 0;
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                var bonus = Random.Shared.Next(1000, 10000);
                var basicSalary = Random.Shared.Next(5000, 10000);
                var tax = Random.Shared.Next(1000, 5000);

                Employees[employeeCount++] = new Employee
                {
                    Id = employeeCount,
                    Name = $"Emp {employeeCount}",
                    Bonus = bonus,
                    BasicSalary = basicSalary,
                    Tax = tax,
                    TotalSalary = basicSalary + bonus - tax 
                };
            }
        }
    }
}