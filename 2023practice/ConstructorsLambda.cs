using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023practice
{
    internal class ConstructorsLambda
    {
        public string FirstName;
        public string LastName;
        public ConstructorsLambda(string firstName, string lastName) =>
            (FirstName, LastName) = (firstName, lastName);
    }
}
