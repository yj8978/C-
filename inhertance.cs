using System;
class Animal
{
    public string Name { get; set; }
    public Animal (string name)
    {
        Name = name;
    }
    public void Sound()
    {
        Console.WriteLine(Name + " makes a sound.");
    }
}
class Dog : Animal
{
    public string Breed { get; set; }
    public Dog (string name, string breed) : base(name)
    {
        Breed = breed ;
    }
    public void Bark()
    {
        Console.WriteLine(Name + " barks.");
    }
}

class Pitbull : Dog
{
    public Pitbull(string name, string breed) : base(name,breed)
    {

    }
    public void PlayFetch ()
    {
        Console.WriteLine(Name + " loves to play fetch!");
    }
}

class Program
{
    static void Main()
    {
        Dog dog = new Dog("Jimmy","Bulldog");
        dog.Sound();
        dog.Bark();
        Pitbull pit = new Pitbull ("Ram","Pitbull");
        pit.Sound();
        pit.Bark();
        pit.PlayFetch();
    }
}