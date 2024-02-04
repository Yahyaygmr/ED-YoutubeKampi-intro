// See https://aka.ms/new-console-template for more information


using intro.Business;
using intro.Entities;

//Console.WriteLine("Hello, World!");
//string message1 = "Merhaba";
//int term = 12;
//double amount = 100000;
//bool isAuthenticated = false;

////variables --> camelCase

//Console.WriteLine(message1 +" "+ term +" \n"+ amount +" "+ isAuthenticated);

////--------------------------------------------------------------------------

//string[] loans = { "Kerdi 1", "Kerdi 2", "Kerdi 3", "Kerdi 4", "Kerdi 5", "Kerdi 6", "Kerdi 7", "Kerdi 8"};

//foreach (string loan in loans)
//{
//    Console.WriteLine("foreach ile :" + loan);
//}
//Console.WriteLine("---------------------------------------------------------------------");
//int i = 0;
//while(i < loans.Length)
//{
//    Console.WriteLine("while ile :" + loans[i]);
//    i++;
//}
//Console.WriteLine("---------------------------------------------------------------------");
//for (int j = 0; j < loans.Length; j++)
//{
//    Console.WriteLine("for ile :" + loans[j]);
//}
//Console.WriteLine("---------------------------------------------------------------------");

//--------------------------------------------------------------------------

//Course course1 = new Course();
//course1.Id = 1;
//course1.Name = "C# kursu";
//course1.Description = "Sıfırdan Zirveye C#";
//course1.Price = 59.99;

//Course course2 = new Course();
//course2.Id = 2;
//course2.Name = "Java";
//course2.Description = "Sıfırdan Zirveye Java";
//course2.Price = 59.99;

//Course course3 = new Course();
//course3.Id = 3;
//course3.Name = "Python";
//course3.Description = "Sıfırdan Zirveye Python";
//course3.Price = 59.99;

//Course[] courses = {course1, course2, course3 };

CourseManager courseManager = new CourseManager();
Course[] courses = courseManager.GetAll();

for (int c = 0; c < courses.Length; c++)
{
    Console.WriteLine(courses[c].Name + "/" + courses[c].Price);
}

