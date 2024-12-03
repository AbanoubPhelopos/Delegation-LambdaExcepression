using Delegation.Data;
using Delegation.Model;

namespace Delegation.Delegates;

public class IntoToDelegate
{
    private readonly ApplicationDb _db = new();
    
    public delegate bool Del(decimal employeeValue, decimal threshold);
    public Del Condition { get; set; }

    public IntoToDelegate(Del condition)
    {
        Condition = condition;
    }
    
    
    
    public void FilterEmployees(decimal salary)
    {
        foreach (var emp in _db.Employees)
        {
            if (Condition(emp.TotalSalary, salary))
            {
                Console.WriteLine($"{emp.Name} with total salary: {emp.TotalSalary}");
            }
        }
    }
    
    // Hands-on 1 
    //implement filter by bonus less than and greater than
    
    
    
    
    // Hands-on 2 
    //implement filter by Tax less than and greater than
    
    
}