namespace courier_delivery_management_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shipment> shipmentList = new List<Shipment>();

            int choice;
            do
            {
                Console.WriteLine("\n===== Courier Delivery Management System =====");
                Console.WriteLine("1. Create Sample Data");
                Console.WriteLine("2. View All Shipments");
                Console.WriteLine("3. Shipment Profile by Type");
                Console.WriteLine("4. Calculate Shipment Cost by ID");
                Console.WriteLine("5. Test ITrackable Interface (Urgent Shipments)");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        CreateSampleData(shipmentList);
                        break;
                    case 2:
                        ViewAllShipments(shipmentList);
                        break;
                    case 3:
                        //DisplayShipmentProfile();
                        break;
                    case 4:
                        //CalculateShipmentCost();
                        break;
                    case 5:
                        //TestITrackableInterface();
                        break;
                    case 6:
                        Console.WriteLine("Exiting system...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 6);
        }
        static void CreateSampleData(List<Shipment> data)
        {

            Console.WriteLine("Sample data creation not yet implemented.");
            FragileShipment fs = new FragileShipment("fs123", "mary", "paul", 50,
                                                   "pending", "12/10/26",
                                                 "just deliver it", false);

            data.Add(fs);
        }
        static void ViewAllShipments(List<Shipment> data)
        {
            foreach (Shipment shipment in data)
            {
                shipment.PrintDetails();
            }
        }
    }
}
