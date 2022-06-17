using System;
using MeuBolsoDigital.Application.Utils.Responses;
using Xunit;

namespace MeuBolsoDigital.Application.Utils.UnitTests.Responses.Results.WithData;

public class ResultSuccessTests
{
    public class FakeEntity { }

    [Fact]
    public void NoData_NoMessage_Success_ReturnTrue()
    {
        // Arrange & Act
        var result = Result<FakeEntity>.Success();

        // Assert
        Assert.True(result.Succeeded);
        Assert.Null(result.Message);
        Assert.Null(result.Data);
    }

    [Fact]
    public void NoData_WithMessage_Success_ReturnTrue()
    {
        // Arrange
        var message = Guid.NewGuid().ToString();

        // Act
        var result = Result<FakeEntity>.Success(message);

        // Assert
        Assert.True(result.Succeeded);
        Assert.Equal(message, result.Message);
        Assert.Null(result.Data);
    }

    [Fact]
    public void WithData_NoMessage_Success_ReturnTrue()
    {
        // Act
        var result = Result<FakeEntity>.Success(new FakeEntity());

        // Assert
        Assert.True(result.Succeeded);
        Assert.Null(result.Message);
        Assert.NotNull(result.Data);
    }

    [Fact]
    public void WithData_WithMessage_Success_ReturnTrue()
    {
        // Arrange
        var message = Guid.NewGuid().ToString();

        // Act
        var result = Result<FakeEntity>.Success(new FakeEntity(), message);

        // Assert
        Assert.True(result.Succeeded);
        Assert.Equal(message, result.Message);
        Assert.NotNull(result.Data);
    }
}
