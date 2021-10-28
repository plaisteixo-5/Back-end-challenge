namespace DomainShared.Commands
{
    public interface ICommand
    {
        bool IsValid();
    }
}