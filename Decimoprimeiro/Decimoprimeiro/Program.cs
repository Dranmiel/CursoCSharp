using System;

namespace Decimoprimeiro {
    class Program {
        static void Main(string[] args) {
            int room, n;
            Quarto[] vect = new Quarto[10];

            Console.Write("How many rooms will be rented? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i<n;i++) {
                string name, email;
                Console.WriteLine("\nRent #" + i + ":");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Email: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());

                vect[room] = new Quarto { Name = name, Email = email };
            }

            Console.WriteLine("\nBusy rooms: ");
            for(int i = 0; i < 10; i++) {
                if(vect[i] != null){
                    Console.WriteLine(i + ":" + vect[i]);
                }
            }

        }
    }
}
