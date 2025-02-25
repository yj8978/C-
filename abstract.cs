using System;
namespace abstratction
{
abstract class AbsC{
    public abstract void AbstractMethod();
    public void NonAbstractMethod()
    {
        Console.WriteLine("Non abs method");
    }
}

class Derived : AbsC{
    public override void AbstractMethod()
    {
        Console.WriteLine("Overriding in derived class");
    }
}

class test{
    static void Main(string[] args)
    {
        Derived d = new Derived();
        d.NonAbstractMethod();
        d.AbstractMethod();
        Console.ReadKey();

    }

}
}
