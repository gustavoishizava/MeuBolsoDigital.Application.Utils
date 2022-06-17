using System;
using MeuBolsoDigital.Application.Utils.Responses;
using Xunit;

namespace MeuBolsoDigital.Application.Utils.UnitTests.Responses.Results.WithData;

public class ResultFailTests
{
    public class FakeEntity { }

    [Fact]
    public void NoMessage_Fail_ReturnFalse()
    {
        // Arrange & Act
        var result = Result<FakeEntity>.Fail();

        // Assert
        Assert.False(result.Succeeded);
        Assert.Null(result.Message);
        Assert.Null(result.Data);
    }

    [Fact]
    public void WithMessage_Fail_ReturnFalse()
    {
        // Arrange
        var message = Guid.NewGuid().ToString();

        // Act
        var result = Result<FakeEntity>.Fail(message);

        // Assert
        Assert.False(result.Succeeded);
        Assert.Equal(message, result.Message);
        Assert.Null(result.Data);
    }
}
