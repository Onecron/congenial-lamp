using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EmployeeClass

{
    private int id;
    private String firstName;
    private String lastName;
    private int salary;

    public EmployeeClass(int id, String firstName, String lastName, int salary)
    {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.salary = salary;
    }
    public EmployeeClass()
    {
        id = 1;
        firstName = "Ryan";
        lastName = "Gosling";
        
    }

    public int getID()
    {
        return this.id;
    }
    public String getfirstName()
    {
        return this.firstName;
    }
    public String getlastName()
    {
        return this.lastName;
    }
    public String getName()
    {
        return "firstName LastName";
    }
    public int getSalary()
    {
        return this.salary;
    }
    public void setSalary(int newsalary)
    {
        this.salary = newsalary;
    }
    public int getAnnualSalary()
    {
        return this.salary * 12;

    }
    public int raiseSalary(int percent)
    {
        return salary = salary * percent;
    }
    public override String ToString()
    {
        return "Employee[id=" + id + " name= " + firstName + lastName + " salary=" + salary + "]";
    }
}