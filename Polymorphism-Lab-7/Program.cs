namespace Polymorphism_Lab_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initiating 5 references of type Geometry.
            Geometry test = new Square(5);
            Geometry test2 = new Circle(3);
            Geometry test3 = new Rectangle(5,3);
            Geometry test4 = new Parallelogram(4,2);
            Geometry test5 = new Ellipse(2, 5);

            //Creating a list for all objects from above.
            List<Geometry> geometries = new List<Geometry>()
            {
                test, test2, test3, test4, test5
            };

            //Looping through all objects.
            foreach (Geometry geometry in geometries)
            {
                //This part works because I made an override of the ToSTring in each class.
                Console.WriteLine(geometry.ToString());
                Console.WriteLine("");
            }
        }
    }
}