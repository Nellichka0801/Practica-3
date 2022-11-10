//Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");

 int[] cubicNumbers(int num)
    {
        int[] cubicArray = new int[num];
        for(int i = 0; i < cubicArray.Length; i++)
        {
            int cNum = i + 1;
            cubicArray[i] = cNum * cNum * cNum;
        }
        return cubicArray;
   }
   int cubicNum = int.Parse(Console.ReadLine());
   Console.WriteLine("Результат");
   int[] cubArr = cubicNumbers(cubicNum);
        for(int i = 0; i < cubArr.Length; i++)
        {
            Console.WriteLine($"{i+1} ^ 3 = " + (cubArr[i]));
        }



