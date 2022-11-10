// // Напишите программу, которая принимает на вход пятизначное число
//  //и проверяет, является ли оно палиндромом. Через строку решать 
//  //нельзя.
// // 14212 -> нет
// // 12821 -> да
// // 23432 -> да

//  1. Ввести пятизначное число
Console.WriteLine("Введите число");
var input = Console.ReadLine();
if (input==null)
input = "0";
int num = int.Parse(input);

bool isPalindrome(int inputNumber)
    {
        int rem, sum = 0, temp;
        temp = inputNumber;
        while (inputNumber > 0)
        {
            rem = inputNumber % 10; //  для получения остатка путем деления на 10  
            inputNumber = inputNumber / 10; 
            sum = sum * 10 + rem; ///умножение суммы на 10 и добавление остатка
        }

        return temp == sum;
    }
    if (isPalindrome(num))
        Console.WriteLine("Число является полиндромом");
    else  
        Console.WriteLine("Число не является полиндромом");
