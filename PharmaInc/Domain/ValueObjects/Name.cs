using FluentValidator;
using FluentValidator.Validation;

namespace Domain.ValueObjects
{
    public class Name : Notifiable
    {
        public Name()
        {
            AddNotifications(
                new ValidationContract()
                .Requires()
                .HasMinLen(FirstName, 3, "FirstName", "O primeiro nome deve conter pelo menos 3 caracteres!")
                .HasMinLen(LastName, 3, "LastName", "O segundo nome deve conter pelo menos 3 caracteres!")
            );

        }
        public string Title { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}