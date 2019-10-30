using System;

namespace BearAdapter
{
    class BearAdapter : IDog
    {
        private IBear bear;

        public void Bark()
        {
            bear.Roar();
        }

        public void Fetch(object objectToFetch)
        {
            bear.LookAt(objectToFetch);
            bear.GoTowards(objectToFetch);
            if (bear.TryEat(objectToFetch))
            {
                Console.WriteLine("Yeeeey, I ate the " + objectToFetch);
            }
            else
            {
                Console.WriteLine("Shit" + objectToFetch + "got away...");
            }
            
        }

        public BearAdapter(IBear bear)
        {
            this.bear = bear;
        }
    }
}
