using System.Reflection.PortableExecutable;

namespace Delegation.Model;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal BasicSalary { get; set; }
    public decimal Bonus { get; set; }
    public decimal Tax { get; set; }
    public decimal TotalSalary { get; set; }
}