using FactoryPattern;
namespace FactoryPattern;

public abstract class BaseEmployee : IEmployee
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual decimal Salary { get; set; }

    public BaseEmployee(int id, string firstName, string lastName, decimal salary)
    {
        ID = id;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Employee ID: {ID} - First name: {FirstName} - Last name: {LastName} - Salary: {Salary}";
    }
}