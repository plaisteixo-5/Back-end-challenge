using Domain.ValueObjects;
using DomainShared.Entities;
using FluentValidator.Validation;

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
            IdUser = id;
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
        public Id IdUser { get; set; }
        public Picture Picture { get; private set; }
        public string Nat { get; private set; }

        public void UpdateUser(User user)
        {
            Gender = (user.Gender != null && user.Gender != "") ? user.Gender : Gender;
            Name = (user.Name != null) ? user.Name : Name;
            Location = (user.Location != null) ? user.Location : Location;
            Email = (user.Email != null && user.Gender != "") ? user.Email : Email;
            Login = (user.Login != null) ? user.Login : Login;
            Dob = (user.Dob != null) ? user.Dob : Dob;
            Registered = (user.Registered != null) ? user.Registered : Registered;
            Phone = (user.Phone != null) ? user.Phone : Phone;
            Cell = (user.Cell != null) ? user.Cell : Cell;
            IdUser = (user.IdUser != null) ? user.IdUser : IdUser;
            Picture = (user.Picture != null) ? user.Picture : Picture;
            Nat = (user.Nat != null) ? user.Nat : Nat;
        }
    }
}