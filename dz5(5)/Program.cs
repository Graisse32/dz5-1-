Console.WriteLine("Напишите ваше число");
int myZnachenie = Convert.ToInt32(Console.ReadLine());
while (1 > 0)
{
    if (myZnachenie % 2 == 0)
    {
        myZnachenie /= 2;
        if (myZnachenie == 1)
        {
            Console.WriteLine("число является степенью 2");
            break;
        }
    }
    else
    {
        Console.WriteLine("число не является степенью 2");
        break;
    }

}