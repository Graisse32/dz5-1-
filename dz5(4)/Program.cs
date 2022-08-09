double bonys;
double zarplata;
int exp;
Console.WriteLine("Запишите зартплату:");
zarplata = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Запишите опыт работы:");
exp = Convert.ToInt32(Console.ReadLine());
if (exp < 5 && exp >= 0)
{
    bonys = 10;
    zarplata += (zarplata * (bonys / 100));
}
else if (exp < 10 && exp >= 5)
{
    bonys = 15;
    zarplata += (zarplata * (bonys / 100));
}
else if (exp < 15 && exp >= 10)
{
    bonys = 25;
    zarplata += (zarplata * (bonys / 100));
}
else if (exp < 20 && exp >= 15)
{
    bonys = 35;
    zarplata += (zarplata * (bonys / 100));
}
else if (exp < 25 && exp >= 20)
{
    bonys = 45;
    zarplata += (zarplata * (bonys / 100));
}
else if (exp >= 25)
{
    bonys = 50;
    zarplata += (zarplata * (bonys / 100));
}
else
{
    Console.WriteLine("Ошибка");
}
Console.WriteLine("Зарплата с бонусами:" + zarplata);
// Операторы и выражения C# (справочник по C#) в статье рассказываеться про разные виды операторов, их условности и методы использования
//Оператор сдвига влево << - опысывает про побитовую операцию сдвига и ее последствия
//Буль Джордж - статься про ученого в честь которого была названа бинарная алгебра
//Логика - статься описывает логику сложных выражений 
//Логика_высказываний - статья содержит материалы трансформации логических высказываний и их правила
//Битовая_маска - в статье описанный способ шифровки битов при котором скрываются некоторые биты