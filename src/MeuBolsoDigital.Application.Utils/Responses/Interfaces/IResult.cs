namespace MeuBolsoDigital.Application.Utils.Responses.Interfaces;

public interface IResult
{
    string Message { get; }
    bool Succeeded { get; }
}

public interface IResult<out TData> : IResult
{
    TData Data { get; }
}