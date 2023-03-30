
using Ganss.Excel;
using System.Collections.Generic;


List<Student> students = new List<Student>()
{
    new Student{Name="Margalit", LastName="Abermad" },
    new Student{Name="Sara", LastName ="Cohen"}
};

ExcelMapper mapper = new ExcelMapper();
var File = @"C:\Users\user\Music\Marga.xlsx";
mapper.Save(File, students,"File",true);

Console.ReadKey();

class Student
{
    public string Name { get; set; }

    public string LastName { get; set; }
}
