Console.WriteLine("Напишите ваше число");
int myZnachennya = Convert.ToInt32(Console.ReadLine());
myZnachennya = myZnachennya & 1;
if (myZnachennya == 1)
{
    Console.WriteLine("число нечетное");
}
else
    Console.WriteLine("число четное");
if (myZnachennya % 2 == 1)
{
    Console.WriteLine("число нечетное");
}
else
    Console.WriteLine("число четное");