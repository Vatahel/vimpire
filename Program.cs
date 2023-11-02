// See https://aka.ms/new-console-template for more information

//приложение которое принимает с клавиатуры два числа, и действия между ними, возводит его с клавиатуры
using System;

class ConsoleCalculatorApp // класс приложения (основа)
{
  #region Создание переменных
  static double num;
  static double num2;
  static string action;// действия между числами

  #endregion

  static void Info()
  { // метод для отображения начальной информации

    Console.WriteLine("~~~~~К А Л Ь К У Л Я Т О Р ~~~~~");
    Console.WriteLine("Введите с помощью клавиатуры и Enter сначало первое число,");
    Console.WriteLine("а затем второе число. Потом введите действие.");
    Console.WriteLine("~~~~~~~~~");
    Console.WriteLine("Поддерживаемые действия: + (сложение), - (вычитание),");
    Console.WriteLine("Поддерживаемые действия: * (умножение), / (деление),");
    Console.WriteLine("Поддерживаемые действия: ** (возведение в степень)");
    Console.WriteLine(" ");
  }

  static void Arguments()
  { // метод для получения чисел

    try // пробуем сделать какое то действие (обработка ислючений)
    {
      // в качестве чисел могут вводиться только цифры
      Console.WriteLine("Введите первое число:");
      num = Convert.ToDouble(Console.ReadLine()); // превращение ввода с клавиатуры в число

      Console.WriteLine("Введите второе число:");
      num2 = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("Введите действия между ними:");
      action = Console.ReadLine();

    }
    catch // если не получается сделать действие из try то выполнить это
    {
      Console.WriteLine("Числа не должны вводиться с помощью букв!");
      Arguments();
    }
  }

  static void Calculation()
  { //метод для расчета степени

    if (action == "**")
    {
      Console.WriteLine($"Результат возведения {num} в степень числа {num2}:");
      Console.WriteLine(Math.Pow(num, num2));

    }

    if (action == "/")
    {
      Console.WriteLine($"Результат деления чисел {num} и {num2}:");
      Console.WriteLine((num / num2).ToString());

    }

    else if (action == "*")
    {
      Console.WriteLine($"Результат умножения чисел {num} и {num2}:");
      Console.WriteLine((num * num2).ToString());

    }

    else if (action == "+")
    {
      Console.WriteLine($"Результат сложения чисел {num} и {num2}:");
      Console.WriteLine((num + num2).ToString());

    }

    else if (action == "-")
    {
      Console.WriteLine($"Результат вычитания чисел {num} и {num2}:");
      Console.WriteLine((num - num2).ToString());


    }
    else
    {
      Console.WriteLine("Такое действие не поддерживается");
    }

  }

  static void Cycle()
  { //метод для повторения программы
    Console.WriteLine(" ");
    Console.WriteLine("Продолжить работу?");
    Console.WriteLine("Введите 'да' что бы продолжить. ");
    Console.WriteLine("Любой другой ввод закроет программу. ");
    if (Console.ReadLine() == "да")
    {
      Main(); // в случае положительного ответа вызывается главный цикл 
    }
  }

  static void Main()
  {  // основной метод, запускающий остальные методы

    Info();// метод для отображения начальной информации
    Arguments();// метод для получения чисел
    Calculation();// метод для расчета 
    Cycle(); //метод для повторения программы

  }
}