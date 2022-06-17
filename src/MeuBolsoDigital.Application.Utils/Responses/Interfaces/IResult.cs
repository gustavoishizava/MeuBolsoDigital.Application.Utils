namespace MeuBolsoDigital.Application.Utils.Responses.Interfaces;

public interface IResult
{
    string Message { get; }
    bool Succeeded { get; }
}

public interface IResult<TData> : IResult
{
    TData Data { get; }
}