# Challenge Project: Accommodation Management

This project is a simple implementation of an accommodation management system, allowing for the registration of guests, suites, and reservations. It calculates the daily rate for reservations, including a discount for extended stays.

## Project Structure

### Models

1. **Person**
   - Represents a guest.
   - Properties:
     - `FirstName` (string): Guest's first name.
     - `LastName` (string): Guest's last name.
     - `FullName` (string): Guest's full name in uppercase.

2. **Suite**
   - Represents a suite available for reservation.
   - Properties:
     - `SuiteType` (string): Type of suite (e.g., "Premium").
     - `Capacity` (int): Maximum number of guests allowed.
     - `DailyRate` (decimal): Cost per day for the suite.

3. **Reservation**
   - Represents a reservation.
   - Properties:
     - `Guests` (List<Person>): List of guests in the reservation.
     - `Suite` (Suite): Reserved suite.
     - `ReservedDays` (int): Number of days reserved.
   - Methods:
     - `RegisterGuests(List<Person>)`: Adds guests to the reservation if the number of guests does not exceed the suite capacity.
     - `RegisterSuite(Suite)`: Assigns a suite to the reservation.
     - `GetGuestCount()`: Returns the total number of guests.
     - `CalculateDailyRate()`: Calculates the total cost for the reservation. Applies a 10% discount for reservations of 10 or more days.

## Usage

1. Clone the repository and navigate to the project folder.

2. Build and run the project.

3. Sample code:

```csharp
using System.Text;
using ChallengeProjectAccommodation.Models;

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
```

## Features

- Add and manage guest information.
- Assign suites to reservations.
- Calculate reservation costs with discounts for long stays.
- Enforce suite capacity rules.

## Requirements

- .NET SDK (6.0 or later).
