namespace Nm;

public class Employee{

    private string firstName;
    private string lastName;
    private double salary;
    

     public Employee(string firstName,string lastName,string dob,String dept,double salary){
        this.firstName=firstName;
        this.lastName=lastName;
        this.dob=dob;
        this.dept=dept;
        this.salary=salary;
     }

    public void setfirstName(String firstName)
    {
        this.firstName=firstName;
    }

    public string getfirstName()
    {
        return this.firstName;
    }
 public void setlastName(String lastName)
    {
        this.lastName=lastName;
    }

    public string getlastName()
    {
        return this.lastName;
    }

 public void setsalary(String salary)
    {
        this.salary=salary;
    }

    public string getsalary()
    {
        return this.salary;
    }


    public override string Tostring()
    {
    return this.firstName+this.lastName+this.salary;
    }



}