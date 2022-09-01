using System;

namespace InheritanceExercise
{
    public abstract class AbstractEntity
    {
        public static int NextId = 0;
        public int Id { get; protected set; }
        protected static int GetNextAvailableId()
        {
            int nextAvailableId = AbstractEntity.NextId;
            AbstractEntity.NextId++;
            return nextAvailableId;
        }

        public virtual void RechargeBattery() //not a great implementation, just practice with virtual/override
        {
            throw new NotImplementedException();
        }
    }
}
