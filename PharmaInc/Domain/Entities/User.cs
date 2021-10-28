using DomainShared.Entities;

namespace Domain.Entities
{
    public class User : Entity
    {
        public User(string gender, Name name, Location location, string email, Login login, Dob dob, Registered registered, string phone, string cell, Id id, Picture picture, Naturality nat)
        : base(id.name, id.value)
        {
            Gender = gender;
            Name = name;
            Location = location;
            Email = email;
            Login = login;
            Dob = dob;
            Registered = registered;
            Phone = phone;
            Cell = cell;
            Picture = picture;
            Nat = nat;
        }

        public string Gender { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }
        public Login Login { get; set; }
        public Dob Dob { get; set; }
        public Registered Registered { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public Picture Picture { get; set; }
        public Naturality Nat { get; set; }
    }
}