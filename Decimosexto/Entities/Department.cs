using System;
using System.Collections.Generic;
using System.Text;

namespace Decimosexto.Entities
{
    class Department
    {
        public string Name { get; set; }
        public Department()
        {
        }

        public Department(string name)
        {
            Name = name;
        }
    }
}
