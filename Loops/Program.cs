for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

string[] kurslar = new string[] { "yazılım", "falan", "filan" };
foreach (var item in kurslar)
{
    Console.WriteLine(item);
}
for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}