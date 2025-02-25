using System;

    string [] names = {"Ram","Sam","Harry"};
    var myLinqQuery = from name in namespace 
    where name.Conatins('a')
    select name ;
    foreach (var name in myLingQuery)
     Console.Write(name+" ");