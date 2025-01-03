# Welcome to the Accommodation Management Project

This project is a simple yet effective way to manage accommodations. You can register guests, assign suites, and calculate reservation costs with ease. Plus, there’s even a discount for longer stays. 🎉

## How It Works

### Key Components

1. **Person**
   - Represents a guest.
   - What it includes:
     - `FirstName` (string): The guest's first name.
     - `LastName` (string): The guest's last name.
     - `FullName` (string): Combines first and last name in uppercase.

2. **Suite**
   - Represents a suite available for booking.
   - What it includes:
     - `SuiteType` (string): The type of suite (e.g., "Premium").
     - `Capacity` (int): Maximum number of guests it can hold.
     - `DailyRate` (decimal): Cost per day for the suite.

3. **Reservation**
   - Represents a booking.
   - What it includes:
     - `Guests` (List<Person>): A list of guests in the reservation.
     - `Suite` (Suite): The suite being reserved.
     - `ReservedDays` (int): How many days the reservation is for.
   - Cool Features:
     - `RegisterGuests(List<Person>)`: Adds guests, as long as they fit the suite capacity.
     - `RegisterSuite(Suite)`: Assigns a suite to the reservation.
     - `GetGuestCount()`: Tells you how many guests are booked.
     - `CalculateDailyRate()`: Figures out the total cost, with a 10% discount for stays of 10+ days.

## Getting Started

1. Clone this repo and navigate to the project folder.
2. Build and run the project.
3. Check out this example to see it in action:

```csharp
using System.Text;
using ChallengeProjectAccommodation.Models;

Console.OutputEncoding = Encoding.UTF8;

// Create guest models and register them
List<Person> guests = new List<Person>();

Person guest1 = new Person(firstName: "Guest 1");
Person guest2 = new Person(firstName: "Guest 2");

guests.Add(guest1);
guests.Add(guest2);

// Create the suite
Suite suite = new Suite(suiteType: "Premium", capacity: 2, dailyRate: 30);

// Create a reservation
Reservation reservation = new Reservation(reservedDays: 5);
reservation.RegisterSuite(suite);
reservation.RegisterGuests(guests);

// Display the results
Console.WriteLine($"Guests: {reservation.GetGuestCount()}");
Console.WriteLine($"Daily rate: {reservation.CalculateDailyRate()}");
```

## Features You’ll Love

- Easily add and manage guest info.
- Assign suites to reservations seamlessly.
- Automatically calculate costs with discounts for long stays.
- Keep bookings within suite capacity.

## What You’ll Need

- .NET SDK (6.0 or later).
