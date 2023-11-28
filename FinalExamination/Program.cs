while (true)
{
    Console.Clear();
    int numberTask = EnterNumber("Enter the number of the task to program output the task! You can press 0 to see the " +
        "conditions of the task! You can pres 666 so that program stoped! \nPress number: ");
    switch (numberTask)
    {
        case 0: // Оглавление
            Console.WriteLine("Below is a list of tasks: ");
            Console.WriteLine("Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
            Console.WriteLine("Task 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
            Console.WriteLine("Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
            Console.ReadKey();
            break;
        case 1: //Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
            int N = EnterNumber($"Enter the number N: ");
            if (N < 1)
            {
                Console.WriteLine("The entered number don't natural!");
            }
            else
            {
                OutputNaturalNumbers(N);
            }
            Console.ReadKey();
            break;
        case 2: //Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
            int taskTwoN = EnterNumber($"Enter the number N: ");
            int taskTwoM = EnterNumber($"Enter the number M: ");
            if (taskTwoN > 0 && taskTwoM > 0)
            {
                if (taskTwoN > taskTwoM)
                {
                    FindSumOfElements(taskTwoM, taskTwoN);
                }
                else if (taskTwoN < taskTwoM)
                {
                    FindSumOfElements(taskTwoN, taskTwoM);
                }
                else if (taskTwoN == taskTwoM)
                {
                    Console.WriteLine($"The sum of natural elements between N and M is {taskTwoN}, because N = M");
                }
            }
            else
            {
                Console.WriteLine("One of the entered numbers don't natural!");
            }
            Console.ReadKey();
            break;
        case 3: //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            int m = EnterNumber($"Enter the number m: ");
            int n = EnterNumber($"Enter the number n: ");
            if (n >= 0 && m >= 0)
            {
                Console.Write($"Функция Аккермана равно {akkermanFunction(m, n)}");
            }
            else
            {
                Console.WriteLine("The entered numbers are negative, which does not correspond to the conditions of the problem!");
            }
            Console.ReadKey();
            break;
        case 666: // Выход из программы
            return;
        default: // Если указываетя несуществующая задача.
            Console.WriteLine("Your entered number of the task doesn't exist!");
            Console.ReadKey();
            break;
    }
}

int EnterNumber(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void OutputNaturalNumbers(int N)
{
    if (N >= 1)
    {
        Console.Write($"{N}; ");
        N--;
        OutputNaturalNumbers(N);
    }
}
void FindSumOfElements(int numberOne, int numberTwo)
{
    int sumOfElements = 0;
    for (int i = 0; numberOne <= numberTwo; numberOne++)
    {
        sumOfElements += numberOne;
    }
    Console.WriteLine($"The sum of natural elements between N and M is {sumOfElements}!");
}
int akkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return akkermanFunction(m - 1, 1);
    else return akkermanFunction(m - 1, akkermanFunction(m, n - 1));
}