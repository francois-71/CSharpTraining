namespace FactoryPattern;

class Program
{
    public static void Main(string[] args)
    {
        // Use the Employee Factory to create an employee. Since a factory is static, we do
        // not need to create an instance of it.

        IEmployee teacher = EmployeeFactory.MakeEmployee(employeeType: EmployeeType.TEACHER, id: 1, firstName: "Bob", lastName: "Marley", salary: 2m);
        IEmployee headOfAdministration = EmployeeFactory.MakeEmployee(employeeType: EmployeeType.HEAD_OF_ADMINISTRATION, id: 2, firstName: "Fred", lastName: "Again", salary: 10m);
        IEmployee cleaner = EmployeeFactory.MakeEmployee(employeeType: EmployeeType.CLEANER, id: 3, firstName: "Beatrice", lastName: "Goldberg", salary: 1m);

        List<IEmployee> employees = [teacher, headOfAdministration, cleaner];

        foreach (IEmployee employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }

    }
}
