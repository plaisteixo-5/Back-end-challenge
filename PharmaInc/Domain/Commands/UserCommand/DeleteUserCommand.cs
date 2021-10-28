using Domain.ValueObjects;
using DomainShared.Commands;

namespace Domain.Commands
{
    public class DeleteUserCommand : ICommand
    {
        public Id Id { get; set; }
    }
}