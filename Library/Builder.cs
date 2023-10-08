using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Builder : Worker
    {

        public Builder(string firstName, string lastName, decimal salary, bool wearsHelmet = true) 
            : base(firstName, lastName, salary, wearsHelmet)
        {
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Position:\t\tBuilder\n";
        }

        public new void Promote(decimal amount)
        { 
            base.Promote(amount);
            Console.WriteLine($"{FirstName} {LastName} was promoted!");
        }
    }
}
