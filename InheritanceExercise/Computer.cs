using System;
using System.Numerics;

namespace InheritanceExercise
{
    public class Computer : AbstractEntity
    {
        public readonly string Manufacturer;
        public readonly string Model;
        public Vector2 ScreenDimensions { get; set; }
        public string OperatingSystem { get; protected set; }

        public Computer(string manufacturer, string model, string os)
        {
            Manufacturer = manufacturer;
            Model = model;
            OperatingSystem = os;
            Id = AbstractEntity.GetNextAvailableId();
        }

        public void ChangeOperatingSystem(string newOs)
        {
            if (newOs != OperatingSystem)
            {
                OperatingSystem = newOs;
            }
            else
            {
                throw new ArgumentException("New operating system must be different than existing operating system!");
            }
        }

        public void SetScreenDimensions(float width, float height)
        {
            if (width < 0f || height < 0f)
            {
                throw new ArgumentOutOfRangeException("Screen dimensions must be positive and non-zero");
            }
            else
            {
                ScreenDimensions = new Vector2(width, height);
            }
        }

        public override string ToString()
        {
            return $"Device #{this.Id} ({this.GetType()}): {this.Manufacturer} {this.Model}, running {this.OperatingSystem}";
        }

        public override bool Equals(object? other)
        {
            if (other == this)
            {
                return true;
            }
            else if (other == null || other.GetType() != this.GetType())
            {
                return false;
            }
            else
            {
                Computer compare = other as Computer;
                return compare.Id == this.Id
                    && compare.Manufacturer == this.Manufacturer
                    && compare.Model == this.Model;
            }
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 6563 * Id;
                hash = 29 * hash * Manufacturer.GetHashCode();
                hash = 29 * hash * Model.GetHashCode();
                return hash;
            }
        }

    }
}
