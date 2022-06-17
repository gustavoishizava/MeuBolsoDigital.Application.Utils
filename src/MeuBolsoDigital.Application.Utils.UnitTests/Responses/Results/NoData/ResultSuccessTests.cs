using System;
using MeuBolsoDigital.Application.Utils.Responses;
using Xunit;

namespace MeuBolsoDigital.Application.Utils.UnitTests.Responses.Results.NoData;

public class ResultSuccessTests
{
    [Fact]
    public void NoMessage_Success_ReturnTrue()
    {
        // Arrange & Act
        var result = Result.Success();

        // Assert
        Assert.True(result.Succeeded);
        Assert.Null(result.Message);
    }

    [Fact]
    public void WithMessage_Success_ReturnTrue()
    {
        // Arrange
        var message = Guid.NewGuid().ToString();

        // Act
        var result = Result.Success(message);

        // Assert
        Assert.True(result.Succeeded);
        Assert.Equal(message, result.Message);
    }
}
