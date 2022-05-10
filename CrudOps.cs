// See https://aka.ms/new-console-template for more information
using ConsoleApp10.Models;

public class CrudOps
{
    EmployeesContext Emp = new EmployeesContext();
    public void AddEnity()
    {


        String EmpName;
        int EmpAge;
        DateTime EmpDOB;
        String EmpGender;


        Employee EmpTb = new Employee();

        do
        {

            Console.WriteLine("Please enter the Name to add");
            EmpName = Console.ReadLine();

        }
        while (EmpName == String.Empty);
        EmpTb.EmpName = EmpName;



        Console.WriteLine("Please enter the Age to add");
        EmpAge = Convert.ToInt32(Console.ReadLine());
        EmpTb.EmpAge = EmpAge;

        Console.WriteLine("Please enter the DOB to add (DD/MM/YYYY)");
        EmpDOB = Convert.ToDateTime(Console.ReadLine());
        EmpTb.EmpDob = EmpDOB;

        Console.WriteLine("Please enter the Gender to add ");
        EmpGender = Console.ReadLine();
        EmpTb.EmpGender = EmpGender;

        Console.WriteLine("Please enter the Gender to add ");
        EmpGender = Console.ReadLine();

        EmpTb.EmpPresentAddress = "null";
        EmpTb.EmpPerAddress = "BLR";
        EmpTb.EmpIsactive = true;
        EmpTb.EmpJoiningDate = Convert.ToDateTime("05 / 08 / 2022");
        EmpTb.EmpManagerId = 3;
        EmpTb.EmpDept = "Edu";

        Emp.SaveChanges();
        Console.WriteLine();
    }

    public void SelectAllEmp()
    {
        var Context = Emp.Employees.ToList();
        foreach (var employee in Context)
        {
            Console.WriteLine($"{employee.EmpId}\t{employee.EmpName}\t{employee.EmpAge}\t{employee.EmpDob}\t{employee.EmpGender}\t{employee.EmpPerAddress}");
        }

    }
    int id;
    public void SelectByEmpID()
    {

        Console.WriteLine("Please enter the id");
        id = Convert.ToInt32(Console.ReadLine());
        var Context = Emp.Employees.ToList().Where(emp => emp.EmpId == id);
      

        foreach (var employee in Context)
        {
            Console.WriteLine($"{employee.EmpId}\t{employee.EmpName}\t{employee.EmpAge}\t{employee.EmpDob}\t{employee.EmpGender}\t{employee.EmpPerAddress}");
        }

    }
    public void UpdatebyID()
    {
        Console.WriteLine("Please enter the id");
        id = Convert.ToInt32(Console.ReadLine());
        var entity = Emp.Employees.FirstOrDefault(e => e.EmpId == id);


        if (entity != null)
        {

            entity.EmpDept = "edu";
            entity.EmpManagerId = 3;


            Emp.Employees.Update(entity);


            Emp.SaveChanges();

        }


    }

    public void DeleteByEmpID()
    {
        Console.WriteLine("Please enter the id");
        id=Convert.ToInt32(Console.ReadLine());
        var entity = Emp.Employees.FirstOrDefault(e => e.EmpId == id);
        Emp.Employees.Remove(entity);
        Emp.SaveChanges();

    }
}












