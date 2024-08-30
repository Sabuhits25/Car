using System;

public class Car : IComparable<Car>, ICloneable, IEquatable<Car>
{
    public string Name { get; set; }
    public int MaxMph { get; set; }
    public int Horsepower { get; set; }
    public decimal Price { get; set; }

    public int CompareTo(Car other)
    {
        if (other == null) return 1;

        return this.Price.CompareTo(other.Price);
    }

    public object Clone()
    {
        return this.MemberwiseClone();
    }

   
    public bool Equals(Car other)
    {
        if (other == null) return false;

        return this.Name == other.Name &&
               this.MaxMph == other.MaxMph &&
               this.Horsepower == other.Horsepower &&
               this.Price == other.Price;
    }

    public override bool Equals(object obj)
    {
        if (obj is Car car)
        {
            return Equals(car);
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, MaxMph, Horsepower, Price);
    }
}
