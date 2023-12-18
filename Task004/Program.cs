using System;

class MainClass {
  public static void Main (string[] args) {
    int number = 12345;
    string numberString = number.ToString();

    int[] array = new int[numberString.Length];

    for (int i = 0; i < numberString.Length; i++) {
        array[i] = int.Parse(numberString[i].ToString());
    }

    Console.WriteLine("Массив цифр числа:");
    foreach (var digit in array) {
        Console.Write(digit + " ");
    }
  }
}
