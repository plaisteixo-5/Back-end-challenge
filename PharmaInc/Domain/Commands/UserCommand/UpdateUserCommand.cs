using Domain.ValueObjects;
using DomainShared.Commands;
using FluentValidator;
using FluentValidator.Validation;

namespace Domain.Commands.UserCommand
{
    public class UpdateUserCommand : Notifiable, ICommand
    {
        public UpdateUserCommand() { }

        public UpdateUserCommand(string gender, Name name, Location location, string email, Login login, Dob dob, Registered registered, string phone, string cell, Id id, Picture picture, string nat)
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

            AddNotifications(new ValidationContract()
                .Requires()
                .HasMinLen(Gender, 3, "Gender", "O genero informado tem que ter mais de 3 caracteres.")
                .IsEmail(Email, "Email", "O email não é válido!"));
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
        public Id Id { get; set; }
        public Picture Picture { get; set; }
        public string Nat { get; set; }
    }
}