using System.Collections.Generic;

namespace LikedExcersize.FlyweightPatterns
{
    public class FlyweightFactory
    {
        private Dictionary<string, Flyweight> flyweigths = new Dictionary<string, Flyweight>();

        public FlyweightFactory()
        {
            flyweigths.Add("X", new ConcreteFlyweight());
            flyweigths.Add("Y", new ConcreteFlyweight());
            flyweigths.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return flyweigths[key];
        }
    }
}
