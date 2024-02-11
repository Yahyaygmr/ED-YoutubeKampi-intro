// See https://aka.ms/new-console-template for more information


using intro.Business;
using intro.DataAccess.Concretes;
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

CourseManager courseManager = new CourseManager(new DapperCourseDal());
List<Course> courses = courseManager.GetAll();

for (int c = 0; c < courses.Count; c++)
{
    Console.WriteLine(courses[c].Name + "/" + courses[c].Price);
}


Console.WriteLine("-----------------------------------------------------");


IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Yahya";
customer1.LastName = "Yağmur";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "89101112131";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "456789";

CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlamaio";
customer3.CustomerNumber = "6789210";
customer3.TaxNumber = "1234567789";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 4;
customer4.Name = "abc";
customer4.CustomerNumber = "678721310";
customer4.TaxNumber = "94231267789";


BaseCustomer[] customers = {customer1, customer2, customer3, customer4 };

//Polymorphism - Çok biçimlilik
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

Console.WriteLine("-----------");