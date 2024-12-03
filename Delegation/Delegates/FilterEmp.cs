using Delegation.Data;

namespace Delegation.Delegates;

public class FilterEmp
{
    private static readonly ApplicationDb _db = new();

    
    
    // Filter employees with total salary greater than a threshold
    public void FilterEmpsWithHighSalary(decimal salary)
    {
        foreach (var emp in _db.Employees)
        {
            if (emp.TotalSalary > salary)
            {
                Console.WriteLine($"{emp.Name} with total salary: {emp.TotalSalary}");
            }
        }
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    // Filter employees with total salary less than a threshold
    public void FilterEmpsWithLowSalary(decimal salary)
    {
        foreach (var emp in _db.Employees)
        {
            if (emp.TotalSalary < salary)
            {
                Console.WriteLine($"{emp.Name} with total salary: {emp.TotalSalary}");
            }
        }
    }
    

    // Filter employees with bonuses greater than a threshold
    public void FilterEmpsWithHighBonus(decimal bonus)
    {
        foreach (var emp in _db.Employees)
        {
            if (emp.Bonus > bonus)
            {
                Console.WriteLine($"{emp.Name} with total salary: {emp.TotalSalary}");
            }
        }
    }

    // Filter employees with tax less than a threshold
    public void FilterEmpsWithLowTax(decimal tax)
    {
        foreach (var emp in _db.Employees)
        {
            if (emp.Tax < tax)
            {
                Console.WriteLine($"{emp.Name} with total salary: {emp.TotalSalary}");
            }
        }
    }
}
