namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //    In the Main method:
            //Create a new instance of the Car class
            //Set values in the properties for the object
            //Print the values of each property to the Console

            Car blueCar = new Car()
            {
                Make = "Mustang",
                Model = "GT-500",
                Year = 2021
            };


            Console.WriteLine(blueCar.Make);
            Console.WriteLine(blueCar.Model);
            Console.WriteLine(blueCar.Year);

        }
}
}
