using System.Collections.Generic;

string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };
Console.WriteLine(isimler[0]);
Console.WriteLine(isimler[1]);
Console.WriteLine(isimler[2]);
Console.WriteLine(isimler[3]);


List<string> isimler2 = new List<string>() { "engin", "murat" };
isimler2.Add("ahmet");
isimler2.Add("ahmet");
isimler2.Add("ahmet");
Console.WriteLine(isimler2[0]);
