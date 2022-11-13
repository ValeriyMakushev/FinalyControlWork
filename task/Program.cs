//Написать программу, которая из имеющегося массива строк, формирут массив стрк, дина которых меньше или равна 3. Первоначальный массив можно вывести с клавиатуры
// либо задать на старте выполнения алгоритма.
// Примеры: ["hellow" "2", "world", ";-"] -> ["2", ";-"]


        int size = 4;
        string[] arrayNew = new string[size];

        Console.WriteLine($"Введите элементы обозначающие строки массива,{size} раза через Enter");
        FillArray(arrayNew);
        Console.Clear();
        PrintArray(arrayNew);
        if (GetSecondMass(arrayNew) == 0) { Console.WriteLine("Нет значений"); }
        else
        {
            string[] arrayTwo = TransferElements(arrayNew);
            PrintArray(arrayTwo);
        }
        void FillArray(string[] arr)
        {
            for (int i = 0; i < size; i++)
            {
                arr[i] = Console.ReadLine() ?? "";
            }
        }

        void PrintArray(string[] arr)
        {
            int arrLeng = arr.Length;
            Console.Write("[ ");
            for (int i = 0; i < arrLeng; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("]");
        }

        int GetSecondMass(string[] arr)
        {

            int secondSize = 0;
        for (int i = 0; i < size; i++)
        {
            if (arr[i].Length <= 3)
            {
                secondSize++;
            }

        }
        return secondSize;
        }
string [] TransferElements(string[] arr)
{
    string[] arrayTwo = new string[GetSecondMass(arrayNew)];
    for (int i = 0, j=0; i < size; i++)
        {
            if (arr[i].Length <= 3)
            {
                arrayTwo[j] = arr[i];
                j++;
            }

        }
        return arrayTwo;
}
