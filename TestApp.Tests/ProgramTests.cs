namespace TestApp.Tests;

public class ProgramTests
{
    // [Fact]
    // public void TestHelloWorld()
    // {
    //     // Arrange
    //     using var writer = new StringWriter();
    //     Console.SetOut(writer);

    //      // Act
    //     var program = Assembly.Load(nameof(TestApp));
    //     program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

    //     // Assert
    //     var output = writer.GetStringBuilder().ToString().TrimEnd();
    //     output.Should().Be("Hello World!");
    // }


    [Fact]
    public void DivideBy4True()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(TestApp));
        bool result2004 = Program.isLeapYear(2004);
        bool result1512 = Program.isLeapYear(1512);
        bool result44 = Program.isLeapYear(44);
        

        // Assert
        result2004.Should().BeTrue();
        result1512.Should().BeTrue();
        result44.Should().BeTrue();
    }


    [Fact]
    public void DivideBy4False()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(TestApp));
        bool result2006 = Program.isLeapYear(2006);
        bool result1511 = Program.isLeapYear(1511);
        bool result47 = Program.isLeapYear(47);
        

        // Assert
        result2006.Should().BeFalse();
        result1511.Should().BeFalse();
        result47.Should().BeFalse();
    }


    [Fact]
    public void TestEdgeCaseDivideBy100()
    {
        // Arrange
        var program = Assembly.Load(nameof(TestApp));

         // Act
        bool result1300 = Program.isLeapYear(1300);
        bool result1600 = Program.isLeapYear(1600);
        

        // Assert
        result1300.Should().BeFalse();
        result1600.Should().BeTrue();
    }

    [Fact]
    public void OutputNay()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1900");
        Console.SetIn(reader);

        // Act
        var program = Assembly.Load(nameof(TestApp));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() }); 
    
        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }
    
    [Fact]
    public void OutputYay()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("2000");
        Console.SetIn(reader);

        // Act
        var program = Assembly.Load(nameof(TestApp));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() }); 
    
        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }
}