using System;

namespace PrChloe_.Models.Components
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AboutMe { get; set; }
        public string Location { get; set; }
        public DateTime BirthdayDate { get; set; }
    }
}