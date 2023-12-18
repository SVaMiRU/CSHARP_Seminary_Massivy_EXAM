using System;

class MainClass {
  public static void Main (string[] args) {
    int[] array = {10, 23, 45, 67, 89, 12, 34, 56, 78, 90};

    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] >= 20 && array[i] <= 90) {
            count++;
        }
    }

    Console.WriteLine("Количество элементов массива, значения которых лежат в отрезке [20,90]: " + count);
  }
}
