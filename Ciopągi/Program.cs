
using System.Drawing;

Vechicle V = new Vechicle(1,"Yellow",new DateOnly(2001,11,9));


Console.WriteLine(V.ToString());
V.Run();

class Vechicle
{
    private int numberOfWheels;
    private string colour;
    private DateOnly productionDate;

    public Vechicle(int numberOfWheels, string colour, DateOnly productionDate)
    {
        if (numberOfWheels <= 0)
        {
            throw new Exception("Vechicles must have at least one wheel");
        }

        this.numberOfWheels = numberOfWheels;
        this.colour = colour;
        this.productionDate = productionDate;
    }

    public override string ToString()
    {
        return
            $"This is Vechicle. \nIt has {numberOfWheels} wheels, {colour} colour and it was produced at: {productionDate.ToString()}";
    }

    public void Run()
    {
        Console.WriteLine("It's running");
    }
}
