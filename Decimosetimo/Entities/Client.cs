using System;
using System.Collections.Generic;
using System.Text;

namespace Decimosetimo.Entities
{
    class Client
    {
        // Propriedades auto implementadas

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        // Contrutores

        public Client()
        {

        }
        public Client(string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
        // Métodos da classe
    }
}
