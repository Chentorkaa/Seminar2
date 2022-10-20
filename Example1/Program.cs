// Напишите ПО, которое принимает на вход 3-х число и на выходе показывает последнюю цифру этого числа. 

int GetLastDigit(int number)
{
        return number%10;
}
Console.WriteLine("Введите число");
int testNumber = int.Parse(Console.ReadLine()); //или прописать число
Console.WriteLine(GetLastDigit(testNumber));
