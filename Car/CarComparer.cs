using System;
using System.Collections.Generic;

public class CarComparer : IComparer<Car>
{
    public enum CompareBy
    {
        Name,
        MaxMph,
        Horsepower,
        Price
    }

    private CompareBy _compareBy;

    public CarComparer(CompareBy compareBy)
    {
        _compareBy = compareBy;
    }

    public int Compare(Car x, Car y)
    {
        if (x == null || y == null) return 0;

        switch (_compareBy)
        {
            case CompareBy.Name:
                return string.Compare(x.Name, y.Name);
            case CompareBy.MaxMph:
                return x.MaxMph.CompareTo(y.MaxMph);
            case CompareBy.Horsepower:
                return x.Horsepower.CompareTo(y.Horsepower);
            case CompareBy.Price:
                return x.Price.CompareTo(y.Price);
            default:
                throw new ArgumentException("Invalid comparison criteria");
        }
    }
}
