using DefaultNamespace;

RentalService service = new RentalService();
DateTime today = DateTime.Today;

Console.WriteLine("=== INITIALIZING SYSTEM ===");

Laptop dellLaptop = new Laptop("Dell XPS", "Intel i7", 16);
Camera canonCamera = new Camera("Canon EOS R", "4K", "50mm");
Projector epsonProjector = new Projector("Epson X", "Model Z", 5);
Laptop brokenMacBook = new Laptop("MacBook Pro", "M1", 8);

service.AddEquipment(dellLaptop);
service.AddEquipment(canonCamera);
service.AddEquipment(epsonProjector);
service.AddEquipment(brokenMacBook);

service.MarkEquipmentUnavailable(brokenMacBook.iD);

Student studentJan = new Student("Jan", "Kowalski");
Employee professorAnna = new Employee("Anna", "Nowak", "Professor");

service.AddUser(studentJan);
service.AddUser(professorAnna);

Console.WriteLine("\n=== DEMONSTRATION SCENARIO ===");

try
{
    Console.WriteLine("Attempting rental...");
    service.RentEqp(studentJan.id, dellLaptop.iD, today, 7);
    Console.WriteLine("Success: Student rented Laptop.");

    Console.WriteLine("\nAttempting to rent unavailable equipment...");
    service.RentEqp(professorAnna.id, brokenMacBook.iD, today, 3);
}
catch (RentalException ex)
{
    Console.WriteLine($"Blocked successfully: {ex.Message}");
}

try
{
    Console.WriteLine("\nAttempting to exceed student limit...");
    service.RentEqp(studentJan.id, canonCamera.iD, today, 3); 
    service.RentEqp(studentJan.id, epsonProjector.iD, today, 3);
}
catch (RentalException ex)
{
    Console.WriteLine($"Blocked successfully: {ex.Message}");
}

Console.WriteLine("\nProcessing on-time return...");
SpecialRecord activeCameraRental = service.GetRentalForEquipment(canonCamera.iD);
if (activeCameraRental != null)
{
    service.ReturnEquipment(activeCameraRental.Id, today.AddDays(2)); 
    Console.WriteLine($"Camera returned. Penalty: {activeCameraRental.PenaltyAmount} PLN");
}

Console.WriteLine("\nProcessing late return...");
SpecialRecord activeLaptopRental = service.GetRentalForEquipment(dellLaptop.iD);
if (activeLaptopRental != null)
{
    service.ReturnEquipment(activeLaptopRental.Id, today.AddDays(10)); 
    Console.WriteLine($"Laptop returned. Penalty applied: {activeLaptopRental.PenaltyAmount} PLN");
}

Console.WriteLine("\n=== DISPLAYING DATA ===");

Console.WriteLine("\nAll Equipment:");
List<Equipment> allEquipment = service.GetAllEquipment();
foreach (Equipment eq in allEquipment)
{
    Console.WriteLine(eq.ToString());
}

Console.WriteLine("\nAvailable Equipment:");
List<Equipment> availableEquipment = service.GetAvailableEquipment();
foreach (Equipment eq in availableEquipment)
{
    Console.WriteLine(eq.ToString());
}

service.PrintSummaryReport();