namespace AccommodationHotelProject.Models
{
    public class Reservation
    {
        public List<Person> Guests { get; set; }
        public Suite Suite { get; set; }
        public int ReservedDays { get; set; }

        public Reservation() { }

        public Reservation(int reservedDays)
        {
            ReservedDays = reservedDays;
        }

        public void RegisterGuests(List<Person> guests)
        {
            if (Suite != null && guests.Count <= Suite.Capacity)
            {
                Guests = guests;
            }
            else
            {
                throw new ArgumentException("The number of guests exceeds the suite capacity.");
            }
        }

        public void RegisterSuite(Suite suite)
        {
            Suite = suite;
        }

        public int GetGuestCount()
        {
            return Guests?.Count ?? 0;
        }

        public decimal CalculateDailyRate()
        {
            decimal rate = ReservedDays * Suite.DailyRate;

            if (ReservedDays >= 10)
            {
                rate *= 0.9M;
            }

            return rate;
        }
    }
}