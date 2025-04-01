namespace GraphQL_c_sharp.Models
{
    public class Resavation
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PartySize { get; set; }
        public string SpecialRequest { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}