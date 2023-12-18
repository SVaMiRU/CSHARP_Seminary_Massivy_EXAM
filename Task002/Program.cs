using System;

class MainClass {
  public static void Main (string[] args) {
    int[] array = {12, 34, 56, 78, 90, 11, 33, 45, 67, 89};

    int count = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count++;
        }
    }

    Console.WriteLine("Количество четных чисел в массиве: " + count);
  }
}
