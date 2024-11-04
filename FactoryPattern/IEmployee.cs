namespace FactoryPattern;
// this interface defines properties of an employee
public interface IEmployee
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }

}