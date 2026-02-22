using graft.nuget.HelloChessService;

namespace HelloChessConsumer.Tests;

public class HelloChessConsumerTests
{
    [Fact]
    public void CallSayHelloChess_ReturnsExpectedString()
    {
        GraftConfig.Host = "ws://localhost/ws";
        // Arrange
        var consumer = new HelloChessGraftConsumer();

        // Act
        var result = consumer.CallSayHelloChess();

        // Assert
        Assert.False(string.IsNullOrWhiteSpace(result));
        Assert.Equal("Hello Chess! Lichess only!", result);
    }
}
