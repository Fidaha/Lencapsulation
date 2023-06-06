using System;

namespace MachineIndustrielle
{
    public class BeerEncapsulator
{
    private double _availableBeerVolume = 600;
    private int _availableBottles;
    private int _availableCapsules;


    public double AvailableBeerVolume
    {
        get { return _availableBeerVolume; }
        private set { _availableBeerVolume = value >= 0 ? 
        value : throw new ArgumentException("Beer volume cannot be negative"); }
    }
   

    public int AvailableBottles
    {
        get { return _availableBottles; }
        set { _availableBottles = value >= 0 ? 
        value :throw new ArgumentException("Number of bottles cannot be negative"); }
    }

    public int AvailableCapsules
    {
        get { return _availableCapsules; }
        set { _availableCapsules = value >= 0 ? 
        value : throw new ArgumentException("Number of capsules cannot be negative"); }
    }

    public void AddBeer(double volume)
    {
        _availableBeerVolume += volume;
    }

      public int ProduceEncapsulatedBeerBottles(int bottlesCount)
    {
        if (AvailableBottles < bottlesCount || AvailableCapsules < bottlesCount || AvailableBeerVolume < bottlesCount * 33)
        {
            Console.WriteLine("Not enough components available to produce {0} bottles", bottlesCount);
            return 0;
        }

        AvailableBottles -= bottlesCount;
        AvailableCapsules -= bottlesCount;
        AvailableBeerVolume -= bottlesCount * 33;

        Console.WriteLine("{0} bottles produced", bottlesCount);
        return bottlesCount;
    }
}
}
