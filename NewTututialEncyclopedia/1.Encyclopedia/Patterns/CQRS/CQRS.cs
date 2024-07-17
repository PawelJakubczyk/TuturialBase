using NewTututial.EasyExcercise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



// src//[ Aplication ]//Abstraction//Messenging//ICommand
public interface ICommand : IBaseCommand
{
}

public interface ICommand<TResponse> : IBaseCommand
{
}

public interface IBaseCommand
{
}
// src//[ Aplication ]//Abstraction//Messenging//IComandHandler
public interface IComandHandler<in TCommand>
    where TCommand : ICommand
{
    Task<Result> Handle(TCommand command, CancellationToken cancellationToken);
}

public interface ICommandHandler<in TCommand, TResponse>
    where TCommand : ICommand<TResponse>
{
    Task<Result<TResponse>> Handle(TCommand command, CancellationToken cancellationToken);
}
// src//[ Aplication ]//Abstraction//Messenging//IQuery
public interface IQuery<TResponse>
{
}
// src//[ Aplication ]//Abstraction//Messenging//IQueryHandler
public interface IQueryHandler<in TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
    Task<Result<TResponse>> Handle(TQuery query, CancellationToken cancellationToken);
}
//Result
public abstract class ResultBase
{
    public string Error { get; }
    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;

    protected ResultBase(string error, bool isSuccess)
    {
        Error = error;
        IsSuccess = isSuccess;
    }
}

public sealed class Result<TType> : ResultBase
{
    public TType? Value { get; }

    private Result(TType? value, string error, bool isSuccess)
        : base(error, isSuccess)
    {
        Value = value;
    }

    public static Result<TType> Success(TType value)
    {
        return new Result<TType>(value, string.Empty, true);
    }

    public static Result<TType> Failure(string error)
    {
        return new Result<TType>(default, error, false);
    }
}

public sealed class Result : ResultBase
{
    public string? Value { get; }

    private Result(string? value, string error, bool isSuccess)
        : base(error, isSuccess)
    {
        Value = value;
    }

    public static Result Success(string value)
    {
        return new Result(value, string.Empty, true);
    }

    public static Result Failure(string error)
    {
        return new Result(null, error, false);
    }
}


//Using Example

public sealed record StartFollowingCommand(Guid UserId, Guid FolowedId) : ICommand;

internal sealed class StartFollowingCommandHandler : ICommandHandler<StartFollowingCommand>
{
    private readonly IUserRespository _userRespository;

    public StartFollowingCommandHandler(IUserRespository userRespository)
    {
        _userRespository = userRespository;
    }

    public async Task<Result> Handle(StartFollowingCommand command, CancellationToken cancellationToken);
    {
        User? user = await _userRespository.GetByIdAsync(command.UserID, cancellationToken);
        if (user is null)
        {
            return UserErrors.NotFound(command.UserId)
        }
    }
}

public interface IUserRespository
{
    Task<User?> GetByIdAsync(Guid Id, CancellationToken cancellationToken = default);
}

public static class UserErrors
{
    public static Error NotFound(Guid userId) => new(
        "Users.NotFound", $"The user with the id = '{userId}' was not found");
}

public sealed record Error(string Code, string Description)
{
    public static implicit operator Result(Error error) => Result.Failure(error);
}