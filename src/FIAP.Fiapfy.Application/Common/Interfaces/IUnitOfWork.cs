namespace FIAP.Fiapfy.Application.Common.Interfaces;

public interface IUnitOfWork
{
    Task CommitAsync();
}