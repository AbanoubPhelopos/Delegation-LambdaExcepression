namespace Delegation.Delegates;

public static class FilteredFunctions
{
    // Conditions to be used with the delegate
    public static bool SalaryGreaterThan(decimal totalSalary, decimal salary)
    {
        return totalSalary > salary;
    }

    public static bool SalaryLessThan(decimal totalSalary, decimal salary)
    {
        return totalSalary < salary;
    }

    public static bool BonusGreaterThan(decimal empBonus, decimal bonus)
    {
        return empBonus > bonus;
    }

    public static bool BonusLessThan(decimal empBonus, decimal bonus)
    {
        return empBonus < bonus;
    }

    
    
    
    public static bool TaxGreaterThan(decimal empTax, decimal tax) => empTax < tax;

    public static bool TaxLessThan(decimal empTax, decimal tax) => empTax < tax;
}