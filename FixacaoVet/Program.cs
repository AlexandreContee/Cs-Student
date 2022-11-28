using System;

namespace FixacaoVet
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] estudante = new Estudante[10];
            Console.Write("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Rent #{i}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Room: ");
                int roomNumber = int.Parse(Console.ReadLine());
                estudante[roomNumber] = new Estudante(name, email);
            }

            Console.WriteLine("Busy rooms:");
            for(int i = 0; i < 10; i++)
            {
                if (estudante[i] != null)
                {
                    Console.WriteLine(i + ": " + estudante[i]);
                }
            }
        }
    }
}