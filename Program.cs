using System;
using System.Collections;

namespace ArrrayList
{
    class Program
    {
        static void Main(string[] args)
        {
          ArrayList studentList = new ArrayList();

Console.WriteLine("them cac phan tu");
studentList.Add(new Student { Name = " Peter ", Age = 20 });
studentList.Add(new Student { Name = "John", Age = 21 });
studentList.Add(new Student { Name = "Mark", Age = 19 });


foreach (Student student in studentList)
    Console.WriteLine(student.Name + " " + student.Age);


studentList[0] = new Student { Name = "Michael", Age = 21 };

Console.WriteLine("thay doi phan tu o vi tri so 0" );
foreach (Student student in studentList)
    Console.WriteLine(student.Name + " " + student.Age);

studentList.RemoveAt(1);

Console.WriteLine("xoa phan tu co index bang 1 ");
foreach (Student student in studentList)
    Console.WriteLine(student.Name + " " + student.Age);


        }
    }
}
