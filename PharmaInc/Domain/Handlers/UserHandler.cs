using Domain.Commands;
using Domain.Commands.UserCommand;
using Domain.Entities;
using Domain.Repositories;
using DomainShared.Commands;
using DomainShared.Handlers;
using FluentValidator;

namespace Domain.Handlers
{
    public class UserHandler :
        IHandler<CreateUserCommand>,
        IHandler<UpdateUserCommand>,
        IHandler<DeleteUserCommand>
    {
        private readonly IUserRepository _repository;

        public UserHandler(IUserRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateUserCommand command)
        {
            if (command.Valid)
            {
                var user = new User(
                    command.Gender,
                    command.Name,
                    command.Location,
                    command.Email,
                    command.Login,
                    command.Dob,
                    command.Registered,
                    command.Phone,
                    command.Cell,
                    command.Id,
                    command.Picture,
                    command.Nat
                );

                _repository.Create(user);

                return new GenericCommandResult(
                    true,
                    "Usuário adicionado",
                    user
                );
            }

            return new GenericCommandResult(
                false,
                "Algo deu errado!",
                command.Notifications
            );
        }

        public ICommandResult Handle(UpdateUserCommand command)
        {
            if (command.Valid)
            {
                var user = _repository.GetById(command.Id.Name, command.Id.Value);

                _repository.Update(user);

                return new GenericCommandResult(
                    true,
                    "Update concluído!",
                    user
                );
            }

            return new GenericCommandResult(
                false,
                $"Algo deu errado! Os dados do usuário {command.Name.FirstName} não foram atualizados!",
                command.Notifications
            );
        }

        public ICommandResult Handle(DeleteUserCommand id)
        {
            var user = _repository.GetById(id.Id.Name, id.Id.Value);

            _repository.Delete(user);

            return new GenericCommandResult(
                true,
                "Usuário excluído com sucesso",
                user
            );
        }
    }
}