using System.Text;
using AccommodationHotelProject.Models;

Console.OutputEncoding = Encoding.UTF8;

// Create guest models and register in the guest list
List<Person> guests = new List<Person>();

Person guest1 = new Person(firstName: "Guest 1");
Person guest2 = new Person(firstName: "Guest 2");

guests.Add(guest1);
guests.Add(guest2);

// Create the suite
Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyRate: 30);

// Create a new reservation, passing the suite and guests
Reservation reservation = new Reservation(reservedDays: 5);
reservation.RegisterSuite(suite);
reservation.RegisterGuests(guests);

// Display the number of guests and the daily rate
Console.WriteLine($"Guests: {reservation.GetGuestCount()}");
Console.WriteLine($"Daily rate: {reservation.CalculateDailyRate()}");