using System;

class MainClass {
  public static void Main (string[] args) {
    double[] array = {3.14, 2.71, 1.618, 2.718, 0.577, 1.414, 2.303, 0.866, 1.732, 2.509};

    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++) {
        if (array[i] < min) {
            min = array[i];
        }
        if (array[i] > max) {
            max = array[i];
        }
    }

    double difference = max - min;

    Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);
  }
}
