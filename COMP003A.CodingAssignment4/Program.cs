// Author: Rosa Ovalle
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = new string[10];
            int[] productQuantities = new int[10];
            int count = 0;

            while (true)
            {
                int menu = 0;
                Console.WriteLine("Welcome to the Inventory Management System!");
                Console.WriteLine("1 Add a Product");
                Console.WriteLine("2 Update Product Quantity");
                Console.WriteLine("3 View Inventory Summary");
                Console.WriteLine("4 Exit");
                Console.Write("Enter your choice: ");
                try
                {
                    menu = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (menu == 1)
                {
                    addItem(productNames, productQuantities, count);
                }
                else if (menu == 2)
                {
                    update(productNames, productQuantities);
                }

                else if (menu == 3)
                {
                    view(productNames, productQuantities,count);
                }
                // Exit the program
                else if (menu == 4)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                // Invalid choice
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                // Add a product 
                static void addItem(string[] productNames, int[] productQuantities, int count)

                {
                    if (count < productNames.Length)
                    {
                        Console.Write("Name of product: ");
                        string product = Console.ReadLine();

                        Console.Write("Quantity amount: ");
                        int amount;
                        if (int.TryParse(Console.ReadLine(), out amount))
                        {
                            productNames[count] = product;
                            productQuantities[count] = amount;
                            count++;
                            Console.WriteLine("Product added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inventory is full!");
                    }
                }
                static void update(string[] productNames, int[] productQuantities)
                // Update product quantity

                {
                    Console.Write("Name of product to update: ");
                    string updateName = Console.ReadLine();
                    int index = Array.IndexOf(productNames, updateName);
                    if (index != -1)
                    {
                        Console.Write("Enter new quantity: ");
                        int updatedQ;
                        if (int.TryParse(Console.ReadLine(), out updatedQ))
                        {
                            productQuantities[index] = updatedQ;
                            Console.WriteLine("Product quantity updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid quantity. Please enter a valid number.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Product not found.");
                    }
                }
                static void view(string[] productNames, int[] productQuantities, int count)
                // View inventory summary

                {
                    Console.WriteLine("\nInventory Summary:");
                    int totalQuantity = 0;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"- {productNames[i]}: {productQuantities[i]}");
                        totalQuantity += productQuantities[i];
                    }

                    int averageQuantity = 0;
                    if (count > 0)
                    {
                        averageQuantity = totalQuantity / count;
                    }

                    Console.WriteLine($"Total Products: {count}");
                    Console.WriteLine($"Total Quantity: {totalQuantity}");
                    Console.WriteLine($"Average Quantity: {averageQuantity}.00");
                } 

               
            }
        }
    }
}
