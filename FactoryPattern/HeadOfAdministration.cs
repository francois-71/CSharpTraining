namespace FactoryPattern;

public class HeadOfAdministration : BaseEmployee
{
    public HeadOfAdministration(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary) { }
    public override decimal Salary
    {
        get
        {
            decimal result = base.Salary + base.Salary * 0.04m;
            return result;
        }
    }
}