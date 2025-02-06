namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] productNames = new string[10];
            int[] productQunatities = new int[10];
            int count = 0;

            Console.WriteLine("Welcome To the Inventory Managment System");
            string choice;

            do
            {
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("Exit");
                Console.Write("Enter Choice: ");
                choice = Console.ReadLine();

                switch (choice)

                {
                    case "1":
                        if (count < 10)
                        {
                            Console.Write("Product Name");
                            string productName = Console.ReadLine();
                            Console.Write("Product Quantities: ");
                            int poductQuantities = int.Parse(Console.ReadLine());
                            productNames[count] = productName;
                        }
                        else
                        {
                            Console.WriteLine("Can only add 5 expenses.");
                        }
                        break;
                }
                } while (choice != "4") ;





            }
    }
}
