using System.Data.Common;

namespace FactoryPattern;

public sealed class Cleaner : BaseEmployee
{
    public Cleaner(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary) { }
    public override decimal Salary
    {
        get
        {
            decimal result = base.Salary + base.Salary * 0.01m;
            return result;
        }
    }
}