
using Construct_Inheritance;

//CustomMath mathOperations=new CustomMath();
//int[] arr1 = { 1, 2, 3, 4, 5 };
//Console.WriteLine("Sum of odd numbers:" + mathOperations.SumOfOdds(arr1));

//int num = 7;
//Console.WriteLine("Number is:" +mathOperations.CheckEvenOrOdd(num));

//int[] arr2 = {1,2,3,4,5};
//Console.WriteLine("Sum of squared numbers:" + mathOperations.SumOfEvenNumbersSquared(arr2));

//int n= 5;
//Console.WriteLine("Factorial of "  + n + "is" +mathOperations.Factorial(n));

//Employee[] employees =
//{
//    new Employee{Id=1,Name="Anar",Surname="Abiyev",Address="123 street",Email="anar@gmail.com",Age=25},
//    new Employee{Id=2,Name="Akif",Surname="Adiyev",Address="23 street",Email="akif@gmail.com",Age = 30},
//    new Employee{Id=3,Name="Ayten",Surname="Aliyev",Address="56 street",Email="ayten@gmail.com",Age=22}
//};

//void PrintEmployeesOlderThan( int age,Employee [] employees)
//{
//    Console.WriteLine("Yashdan boyuk olan employeeler:");
//    foreach(Employee emp in employees)
//    {
//        if (emp.Age > age)
//        {
//            Console.WriteLine(emp.Name + " " + emp.Surname);
//        }
//    }
//}
//PrintEmployeesOlderThan(25, employees);


//int CountEmplyeeBetweenAges( Employee[] employees, int startAge,int endAge) 
//{int count = 0;

//    foreach(Employee emp in employees)
//    {
//        if (emp.Age >= startAge && emp.Age <= endAge)
//        {
//            count++;
//        }
//    }
//    return count;

//}
//int count=CountEmplyeeBetweenAges(employees,20,30);
//Console.WriteLine("20 ve 30 arasinda olan telebelerin sayi: " + count);

//int GetTotalAgeOfEmployees(Employee[] employees)
//{
//    int totalAge=0; 
//    foreach(Employee emp in employees)
//    {
//        totalAge+= emp.Age;
//    }
//    return totalAge;
//}
//int totalAge=GetTotalAgeOfEmployees(employees);
//Console.WriteLine("butun employeelerin yashin cemi: " + totalAge);

//void PrintEmployeesWithEmailStartingWith(string prefix, Employee[] employees)
//{
//    Console.WriteLine("Emaili'"+prefix +"' ile baslayan employeeler:");
//    foreach(Employee emp in employees)
//    {
//        if (emp.Email.StartsWith(prefix))
//        {
//            Console.WriteLine(emp.Name + " " + emp.Surname + "-" + emp.Email);
//        }
//    }
//}
//PrintEmployeesWithEmailStartingWith("a",employees);
//Person person = new()
//{
//    id = 1,
//    fullName = "Fatime Qaraxanova",
//    age = 22,
//    position = "student"
//};

//Person person = new(1,"Hacixan Hacixanov",19,"Student");
//Console.WriteLine(person.fullName);
//Person person = new Person("Azerbaycan","Turkiye");

Person person1 = new Person()
{
    id = 1,
    fullName = "Ilqar Shireyev",
    age = 26
};
Person person2 = new Person()
{
    id = 2,
    fullName = "Reshad Agayev",
    age = 22
};
Person person3 = new Person()
{
    id = 3,
    fullName = "Nurlan Umudov",
    age = 23
};
Person person4 = new Person()
{
    id = 4,
    fullName = "Elmir Shireyev",
    age = 21
};

Person[] people = {person1 , person2 , person3 , person4 };
Person FindStudentById(Person[]people, int id)
{
    return people.FirstOrDefault(m=>m.id == id);
    
}
Person result=FindStudentById(people, 100);
if (result != null)
{
    string response = $"id:{result.id} Fullname:{result.fullName} Age: {result.age}";
    Console.WriteLine(response);
}
else
{
    Console.WriteLine("Data not found");
}
