namespace ConfigService.Tests;

public class ConfigService_Test
{
    [Fact]
    public void GetValue_Test()
    {
        var configService = new ConfigService();
        string result = configService.GetValue();

        Assert.Equal("exampleValue", result);
    }
}