using System;
namespace Program
{
    class Lambda_Exp
    {
        public void Lambda()
        {
            Func<int,int,int> sub = (x,y) => x - y ;
            Console.WriteLine(sub(20,11));
        }
    }

    class MainClass
    {
        static void Main()
        {
            Lambda_Exp lam = new Lambda_Exp();
            lam.Lambda();
        }
    }
}