﻿string[] snack = { "sushi", "pizza", "burger", "chicken wings", "Asian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snack.Length);

Console.WriteLine($"Tonight we are going to eat {snack[randomIndex]}");

