namespace FactoryPattern;

public sealed class Teacher : BaseEmployee
{
    public Teacher(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary) { }

    public override decimal Salary
    {
        get
        {
            decimal result = base.Salary + base.Salary * 0.02m;
            return result;
        }
    }
}
