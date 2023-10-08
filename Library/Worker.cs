namespace Library
{
    public abstract class Worker : IDisposable
    {
        public string FirstName { get; }
        public string LastName { get; }
        public decimal Salary { get; protected set; }
        public bool WearsHelmet { get; private set; }
        public abstract int YearsOfExperience { get; }

        public Worker(string firstName, string lastName, decimal salary, bool wearsHelmet = true)
        {
            (FirstName, LastName, Salary, WearsHelmet) = (firstName, lastName, salary, wearsHelmet);
        }

        public virtual string GetInfo()
        {
            return $"First name:\t\t{FirstName}\n" +
                   $"Last name:\t\t{LastName}\n" +
                   $"Salary:\t\t\t{Salary}\n" +
                   $"Wears protection:\t{(WearsHelmet ? "yes" : "no")}\n" +
                   $"Years of experience:\t{YearsOfExperience}\n";
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

        public abstract void Greet();
        public void Dispose()
        {
            Console.WriteLine($"Disposing of all Mr {LastName}'s unmanaged possessions and body...");
        }
    }
}