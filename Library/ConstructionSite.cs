using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ConstructionSite<T> where T : Worker
    {
        private  readonly List<T> _workers = new();
        public IReadOnlyCollection<T> Workers => _workers.AsReadOnly();

        public ConstructionSite(params T[] workers)
        {
            Console.WriteLine("New construction project is starting.\n");
            foreach (var worker in workers)
            {
                HireEmployee(worker);
            }
        }
        public void FireEmployee(T worker)
        {
            if (_workers.Contains(worker))
            {
                _workers.Remove(worker);
            }
        }
        public void HireEmployee(T worker)
        {
            if (!_workers.Contains(worker))
            {
                _workers.Add(worker);
                Console.WriteLine($"{worker.FirstName} {worker.LastName} was hired");
            }
        }

        public void IncidentOccurred()
        {
            Console.WriteLine("Oh no! A brick falls from the upper floor of the building!");
            if (_workers.Count > 0)
            {
                var chosenOne = _workers[new Random().Next(_workers.Count)];

                Console.WriteLine($"What a disaster! Brick falls directly on {chosenOne.FirstName} {chosenOne.LastName}!");

                if (chosenOne.WearsHelmet)
                {
                    Console.WriteLine($"Thank God he didn't forget to put his helmet on. " +
                                      $"Helmet breaks, but {chosenOne.FirstName}'s head is still in one piece." +
                                      $" He takes the rest of the day off with a light concussion...");
                    chosenOne.TakeHelmetOff();
                }
                else
                {
                    Console.WriteLine($"{chosenOne.FirstName} was a christian and put all his faith in God instead of a primitive piece of plastic. " +
                                      $"Well, at least now he has a chance to personally thank his creator... Funeral is tomorrow");
                    _workers.Remove(chosenOne);
                    chosenOne.Dispose();
                }
            }
            else
            {
                Console.WriteLine("But the construction site is empty, brick loudly falls " +
                                  "to the ground shattering into small pieces and raising a cloud of dust... Everybody is fine");
            }
        }
    }
}
