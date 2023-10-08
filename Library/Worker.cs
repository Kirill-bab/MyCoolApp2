namespace Library
{
    public abstract class Worker
    {
        public string FirstName { get; }
        public string LastName { get; }
        public decimal Salary { get; protected set; }
        public bool WearsHelmet { get; private set; }

        public virtual string GetInfo()
        {
            return $"First name:\t\t{FirstName}\n" +
                   $"Last name:\t\t{LastName}\n" +
                   $"Salary:\t\t\t{Salary}\n" +
                   $"Wears protection:\t{(WearsHelmet ? "yes" : "no")}\n";
        }

        public void Promote(decimal amount)
        {
            Salary += amount;
        }

        public void PutHelmetOn()
        {
            WearsHelmet = true;
        }

        public void TakeHelmetOff()
        {
            WearsHelmet = false;
        }

        public Worker(string firstName, string lastName, decimal salary, bool wearsHelmet = true)
        {
            (FirstName, LastName, Salary, WearsHelmet) = (firstName, lastName, salary, wearsHelmet);
        }
    }
}