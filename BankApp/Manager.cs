
using namespace nm;
public class Manager:Employee{
    private string mgrName;
    private double salary;
    

   public Manager(string mgrName)
   {
       base(salary);
       this.mgrName=mgrName;
      
   }

   public string setmgrName(string mgrName)
   {
    this.mgrName=mgrName;
   }

   public void getmgrName()
   {
    return this.mgrName;
   }




}