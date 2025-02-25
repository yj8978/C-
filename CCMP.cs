using System;
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void OP()
    {
        Console.WriteLine("Hello, I am " + Name + "  and I am " + Age + " years old.");    
     }

}
class Program
{
    static void Main()
    {
        Person person1 = new Person("Yogesh Jirel",20);
        person1.OP();
        Person person2 = new Person("Ram",19);
        person2.OP();
    }
}