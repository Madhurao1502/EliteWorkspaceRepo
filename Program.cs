// See https://aka.ms/new-console-template for more information
using ConsoleApp10;

CrudOps op = new CrudOps();

Console.WriteLine("Please select options");
int n=Convert.ToInt32(Console.ReadLine());

here:
switch(n)
{
    case 1: op.AddEnity();
        goto here;
    case 2: op.SelectAllEmp();
            goto here;
    case 3: op.SelectByEmpID();
        goto here;
    case 4: op.UpdatebyID();
        goto here;
    case 5: op.DeleteByEmpID();
        goto here;
    default: Console.WriteLine("Thank you ");
        break;








}












