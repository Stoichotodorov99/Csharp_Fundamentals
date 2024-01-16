﻿namespace ex7.waterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;
            int n = int.Parse(Console.ReadLine());
            int totalQuantity = CAPACITY;

            for (int i = 0; i < n; i++)
            {
                int quantity = int.Parse(Console.ReadLine());
                if (totalQuantity - quantity >= 0)
                {
                    totalQuantity -= quantity;

                }
                else
                {
                    Console.WriteLine("Insufficient capacity!"); 
                }
            }
            int totalFilledQuantity = CAPACITY - totalQuantity;
            Console.WriteLine(totalFilledQuantity);
        }
    }
}
