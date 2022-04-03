
using _1_2_FactoryMethod.Solution1;

public class Program
{
    public static void Main(string[] args)
    {
        
    }

    public void Solution1()
    {
        HR hr = new HR();
        PayrollOffice po = new PayrollOffice();

        Factory employeeFactory = new EmployeeFactory();
        Factory managerFactory = new ManagerFactory();
        Factory directorFactory = new DirectorFactory();

        hr.AddNewEmployee(employeeFactory.Create());
        hr.AddNewEmployee(employeeFactory.Create());
        hr.AddNewEmployee(employeeFactory.Create());
        hr.AddNewEmployee(managerFactory.Create());
        hr.AddNewEmployee(managerFactory.Create());
        hr.AddNewEmployee(directorFactory.Create());

        hr.listEmployee();

        // Now pay time!

        List<Employee> employees = new List<Employee>();

        foreach(Employee employee in employees)
        {
            po.PaySalary(employee);
        }



    }
}
