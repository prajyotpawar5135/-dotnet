// See https://aka.ms/new-console-template for more information

using BOLl;
using DALi;

Console.WriteLine("Hello, prajyot!");


List<Student> students=DALi.Class1.getAllStudents();
foreach (var st in students)
{
    Console.WriteLine(st);
}
