using Delegation.Data;
using Delegation.Model;

namespace Delegation.Delegates;

public class Filter
{
    private static readonly ApplicationDb _db = new();

    public delegate bool EmployeeFilter(Employee emp);

    public static void FilterEmployees(EmployeeFilter filter)
    {
        foreach (var emp in _db.Employees)
        {
            if (filter(emp))
            {
                Console.WriteLine($"{emp.Name} with total salary: {emp.TotalSalary}");
            }
        }
    }
    
}