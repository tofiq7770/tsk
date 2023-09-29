
//using ConsoleApp1;
//Employee employee = new()
//{
//    fullName = "Tofiq Nasibli",
//    age = 28,
//    adress = "Bilacari"


//};


//Console.WriteLine(employee.GetFullData());



////
//using ConsoleApp1;

//Employee employee1 = new()
//{
//    fullName = "Tofiq Nasibli",
//    age = 28,
//    adress = "Bilacari"


//};



//Employee employee2 = new()
//{
//    fullName = "Ali Huseynov",
//    age = 28,
//    adress = "Yasamal"


//};



//Employee employee3 = new()
//{
//    fullName = "Shahriyar Alxanov",
//    age = 37,
//    adress = "Badamdar"


//};


//Employee[] employees = {employee1, employee2, employee3};

//foreach (Employee employee in employees)

//    Console.WriteLine(employee.GetFullData());


//using ConsoleApp1;

//Book book = new Book();


//using ConsoleApp1;

//Book book = new Book();





//using ConsoleApp1;

//Book book = new Book();

//book.name = "Martin Iden";
//book.author = "Mark Twen";

//Console.WriteLine(book.GetData());




//using ConsoleApp1;

//Book book = new Book("Tom","Jerry");

//Console.WriteLine(book.GetData());





//using ConsoleApp1;

//Book book = new Book(100,"Azerbaycan");



//using ConsoleApp1.Models;

//User user1 = new User
//{
//    id = 1,
//    fullName = "Tofiq Nasibli",
//    age = 18
//};



//User user2 = new User
//{
//    id = 2,
//    fullName = "Ali huseynov",
//    age = 19
//};




//User user3 = new User
//{
//    id = 3,
//    fullName = "Bali ",
//    age = 13
//};



//User user4 = new User
//{
//    id = 4,
//    fullName = "Ali shukurlu",
//    age = 42
//};


//User[] people = {user1, user2, user3, user4};


//foreach (var person in people)
//{
//    Console.WriteLine(person.fullName);


//}



//using ConsoleApp1.Models;

//User user1 = new User
//{
//    id = 1,
//    fullName = "Tofiq Nasibli",
//    age = 18
//};



//User user2 = new User
//{
//    id = 2,
//    fullName = "Ali huseynov",
//    age = 19
//};


//User user3 = new User
//{
//    id = 3,
//    fullName = "Ali Shukurlu",
//    age = 18
//};



//User user4 = new User
//{
//    id = 4,
//    fullName = "Balaysa Isayev",
//    age = 78
//};


//User[] people = { user1, user2, user3, user4 };


//foreach (var person in people)
//{
//    if (person.id == 1)
//    {
//        Console.WriteLine(person.fullName);
//    }
//}


//var result = people.FirstOrDefault(m => m.id > 3);

//Console.WriteLine(result.fullName);




//var result = people.Where(m => m.id>2).ToArray();

//foreach (var person in result)
//{
//    Console.WriteLine(person.fullName);
//}


//using ConsoleApp1.Models;




//static void ShowUsers()
//{

//    var result = GetAllUsers();


//    foreach (var user in result)
//    {
//        Console.WriteLine(user.fullName);
//    }

//}



//static User[] GetAllUsers()
//{

//    User user1 = new User
//    {
//        id = 1,
//        fullName = "Tofiq Nasibli",
//        age = 18
//    };



//    User user2 = new User
//    {
//        id = 2,
//        fullName = "Ali Huseynov",
//        age = 19
//    };



//    User user3 = new User
//    {
//        id = 3,
//        fullName = "Ali Shukurlu",
//        age = 17
//    };



//    User user4 = new User
//    {
//        id = 4,
//        fullName = "Subhan Aliyev",
//        age = 18
//    };


//    User[] people = { user1, user2, user3, user4 };

//    return people;

//}