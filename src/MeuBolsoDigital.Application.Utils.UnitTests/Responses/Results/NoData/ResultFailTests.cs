using System;
using MeuBolsoDigital.Application.Utils.Responses;
using Xunit;

namespace MeuBolsoDigital.Application.Utils.UnitTests.Responses.Results.NoData;

public class ResultFailTests
{
    [Fact]
    public void NoMessage_Fail_ReturnFalse()
    {
        // Arrange & Act
        var result = Result.Fail();

        // Assert
        Assert.False(result.Succeeded);
        Assert.Null(result.Message);
    }

    [Fact]
    public void WithMessage_Fail_ReturnFalse()
    {
        // Arrange
        var message = Guid.NewGuid().ToString();

        // Act
        var result = Result.Fail(message);

        // Assert
        Assert.False(result.Succeeded);
        Assert.Equal(message, result.Message);
    }
}