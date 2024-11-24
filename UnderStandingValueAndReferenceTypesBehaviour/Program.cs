var person = new Person { Age = 20 };
ChangePerson(person);
Console.WriteLine(person.Age); // 40
ChangePersonAgeWithNew(person);
Console.WriteLine(person.Age); // 40
ChangePersonAgeByRef(ref person);
Console.WriteLine(person.Age); // 30

static void ChangePerson(Person person)
{
    person.Age = 40;
}
static void ChangePersonAgeWithNew(Person person)
{
    person = new Person { Age = 60 };
}
static void ChangePersonAgeByRef(ref Person person)
{
    person = new Person { Age = 30 };
}
public class Person
{
    public int Age { get; set; }
}