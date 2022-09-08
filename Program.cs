using System;
int number1, number2, result, action;
Console.WriteLine("Enter Your First Number");
number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Your Second Number");
number2 = int.Parse(Console.ReadLine());
result = 0;
Console.WriteLine("1 For Addition");
Console.WriteLine("2 For Subtraction");
Console.WriteLine("3 For Muliplication");
Console.WriteLine("4 For Division");
action = int.Parse(Console.ReadLine());
int Addition(int number1, int number2)
{
    int result = number1 + number2;
    return result;
}
int Subtraction(int number1, int number2)
{
    int result = number1 - number2;
    return result;
}
int Multiplication(int number1, int number2)
{
    int result = number1 * number2;
    return result;
}
int Division(int number1, int number2)
{
    int result = number1 / number2;
    return result;
}
Console.WriteLine("The result is {0}", result);
switch (action)
{
    case 1:
        {
            result = Addition(number1, number2);

            break;
        }
    case 2:
        {
            result = Subtraction(number1, number2);
            break;
        }
    case 3:
        {
            result = Multiplication(number1, number2);
            break;
        }
    case 4:
        {
            result = Division(number1, number2);
            break;
        }
    default:
        Console.WriteLine("Sorry Wrong Action");
        break;

}
if (result != 0)
{
    Console.WriteLine("The result is {0}",result);
}