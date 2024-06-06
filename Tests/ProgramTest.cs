using System;
using System.IO;
using Xunit;

namespace Tests
{
    public class ProgramTest
    {
        [Fact]
        public void TestEvenNumber()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("4");
            Console.SetIn(reader);

            // Act
            StudentSubmission.Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Even", output);
        }

        [Fact]
        public void TestOddNumber()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var reader = new StringReader("3");
            Console.SetIn(reader);

            // Act
            StudentSubmission.Program.Main(new string[0]);

            // Assert
            var output = writer.GetStringBuilder().ToString().Trim();
            Assert.Equal("Odd", output);
        }
    }
}
