namespace NewTututialEncyklopedia.EasyExcercise;

public sealed class Result<TType>
{
    public TType? Value { get; set; }
    public string Error { get; set; }
    public bool IsSuccess => Value is not null;
    public bool IsFailure => !IsSuccess;

    public Result(TType value, string error)
    {
        Value = value;
        Error = error;
    }
}