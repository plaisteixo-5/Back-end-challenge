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


            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Gender, 3, "Gender", "O genero informado tem que ter mais de 3 caracteres.")
                .IsEmail(Email, "Email", "O email não é válido!"));
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
    }
}