Console.WriteLine("Введите первое число :");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число :");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число :");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num2 < num1 && num1 > num3)
{
    Console.WriteLine(num1);
}

else if (num1 < num2 && num2 > num3)
{
    Console.WriteLine(num2);
}

else

{
    Console.WriteLine(num3);
}
