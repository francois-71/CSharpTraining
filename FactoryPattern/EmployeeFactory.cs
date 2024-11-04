namespace FactoryPattern;

public static class EmployeeFactory
{
    public static IEmployee MakeEmployee(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
    {
        switch (employeeType)
        {
            case EmployeeType.TEACHER:
                return new Teacher
                (
                    id: id,
                    firstName: firstName,
                    lastName: lastName,
                    salary: salary
                );

            case EmployeeType.CLEANER:
                return new Cleaner
                (
                    id: id,
                    firstName: firstName,
                    lastName: lastName,
                    salary: salary
                );
            case EmployeeType.HEAD_OF_ADMINISTRATION:
                return new HeadOfAdministration
                (
                    id: id,
                    firstName: firstName,
                    lastName: lastName,
                    salary: salary
                );

            default:
                throw new NotSupportedException("Employee type not supported");
        }
    }
}