 using System;
 class add
 {
   static void Main(string[] args)
        {
            Console.WriteLine("This is my first program in C#");
            int n1, n2;
            Console.Write("Enter n1:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n2:");
            n2 = int.Parse(Console.ReadLine());
            int sum = n1 + n2;
            Console.WriteLine("The sum is:" + sum);
            Console.WriteLine("The sum is:"+ n1 +"and"+ n2 + " " sum);
            Console.WriteLine("The sum of {0} and {1} is {2}", n1, n2, sum);
            Console.ReadKey();
        }
 }