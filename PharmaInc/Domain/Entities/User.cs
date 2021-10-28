using Domain.ValueObjects;
using DomainShared.Entities;

namespace Domain.Entities
{
    public class User : Entity
    {
        public User(
            string gender,
            Name name,
            Location location,
            string email,
            Login login,
            Dob dob,
            Registered registered,
            string phone,
            string cell,
            Id id,
            Picture picture,
            string nat
        )
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
            Id = id;
            Picture = picture;
            Nat = nat;
        }

        public string Gender { get; private set; }
        public Name Name { get; private set; }
        public Location Location { get; private set; }
        public string Email { get; private set; }
        public Login Login { get; private set; }
        public Dob Dob { get; private set; }
        public Registered Registered { get; private set; }
        public string Phone { get; private set; }
        public string Cell { get; private set; }
        public Id Id { get; set; }
        public Picture Picture { get; private set; }
        public string Nat { get; private set; }
    }
}