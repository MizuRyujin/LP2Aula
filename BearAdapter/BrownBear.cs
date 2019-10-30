using System;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        Random rnd;
        public bool Hibernating { get; set; }

        public void GoTowards(object objectToWalkTowards)
        {
            if (!Hibernating)
            {
                Console.WriteLine("Bear is moving towards " + objectToWalkTowards);
            }
        }

        public void LookAt(object objectToLookAt)
        {
            if (!Hibernating)
            {
                Console.WriteLine("Looking at " + objectToLookAt);
            }
        }

        public void Roar()
        {
            if (Hibernating)
            {
                Console.WriteLine("zzzZZZZzzzZZZ");
            }
            else
            {
                Console.WriteLine("Rooooooaaaar!!! xD");
            }
        }

        public bool TryEat(object objectToEat)
        {
            if (!Hibernating && rnd.NextDouble() > 0.7)
            {
                return true;
            }
            return false;
        }

        public BrownBear(bool hibernating = false)
        {
            rnd = new Random();
            hibernating = Hibernating;
        }
    }
}
