using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Builder : Worker
    {
        public override int YearsOfExperience { get; }
        public Builder(string firstName, string lastName, decimal salary, int yearsOfExp, bool wearsHelmet = true) 
            : base(firstName, lastName, salary, wearsHelmet)
        {
            YearsOfExperience = yearsOfExp;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + "Position:\t\tBuilder\n";
        }

        public new void Promote(decimal amount)
        { 
            base.Promote(amount);
            Console.WriteLine($"{FirstName} {LastName} was promoted!");
        }

        public override void Greet()
        {
            Console.WriteLine("Morning, mate!");
        }
    }
}
