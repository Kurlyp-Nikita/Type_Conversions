// See https://aka.ms/new-console-template for more information
using Type_Conversions;




//Inploy employee = new Inploy("Tom", "Microsoft");
//Person person = employee;   // преобразование от Inploy к Person

//Console.WriteLine(person.Name);



//Client client = new Client("Nikita", "Tinkoff");
//Person person0 = client;

//Console.WriteLine(person0.Name);


object person1 = new Inploy("Tom", "Microsoft");  // от Employee к object
object person2 = new Client("Bob", "ContosoBank");  // от Client к object
object person3 = new Person("Sam");                 // от Person к object

Console.WriteLine(person1);

