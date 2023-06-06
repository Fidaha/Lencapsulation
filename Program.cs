namespace MachineIndustrielle;

class Program
{
    static void Main(string[] args)
    {
        
        var beerEncapsulator = new BeerEncapsulator();
        
        beerEncapsulator.AvailableBottles = 255;
        beerEncapsulator.AvailableCapsules = 355;

        beerEncapsulator.AddBeer(6);


        int producedBottles = beerEncapsulator.ProduceEncapsulatedBeerBottles(10000000);
    }
}
