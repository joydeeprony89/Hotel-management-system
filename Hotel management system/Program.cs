using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_management_system
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    #region enums

    public enum AccountStatus
    {

    }

    public enum RoomStatus
    {

    }

    public enum RoomType
    {

    }

    public enum BookingStatus
    {

    }

    public enum HotelStatus
    {

    }
    #endregion

    #region User related

    public class Account
    {
        public string id { get; set; }

        public string password { get; set; }

        public AccountStatus status { get; set; }

        public bool ResetPassword() { return true; }
    }

    public abstract class User
    {
        public Account Account { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string email { get; set; }
        public int phone { get; set; }

        public bool UpdateDetails(User user) { return true; }

        public abstract List<Booking> GetBookings();
        public abstract bool createBooking(Booking booking);
        public abstract bool cancelBooking(Booking booking);
        public abstract bool updateBooking(Booking booking);
    }

    public class Receptionist : User
    {
        public Booking getBooking() { return null; }

        public override List<Booking> GetBookings()
        {
            throw new NotImplementedException();
        }

        public override bool createBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public override bool cancelBooking(Booking booking)
        {
            throw new NotImplementedException();
        }

        public override bool updateBooking(Booking booking)
        {
            throw new NotImplementedException();
        }
    }

    #endregion

    #region Hotel

    public class HotelLocation
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Pin { get; set; }
    }
    public class Hotel
    {
        public string Name { get; set; }
        public List<HotelLocation> Locations { get; set; }

        public bool AddLocation(HotelLocation location) { return true; }
    }
    #endregion

    #region Hotel Room's

    public class Room
    {
        public string RoomNo { get; set; }
        public double Tarif { get; set; }
        public RoomStatus Status { get; set; }
        public RoomType Type { get; set; }
        public List<RoomKey> RoomKeys { get; set; }
        public bool isAvailable() { return true; }

        public List<Room> GetAvailableRoomsForBooking(RoomType type, DateTime startdate, int duration) { return null; }

    }

    public class RoomKey
    {
        public string KeyNo { get; set; }
        public bool AssignKey(Room room) { return true; }
    }

    #endregion

    #region Booking

    public class Booking
    {
        public string BookingNo { get; set; }
        public DateTime BookingDate { get; set; }
        public int Duration { get; set; }
        public Invoice  Invoice { get; set; }
        public BookingStatus BookingStatus { get; set; }
        public User BookedBy { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }

    public class Invoice
    {
        public string Number { get; set; }
        public DateTime InvoicingDate { get; set; }
    }

    #endregion
}
