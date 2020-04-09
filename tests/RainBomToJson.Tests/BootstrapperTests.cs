 using System.IO;
 using RainBomToJson.Application.Exceptions;
 using RainBomToJson.Interface;
 using Xunit;

namespace RainBomToJson.Tests
{
    public class BootstrapperTests
    {
        [Fact]
        public void WhenRanShouldntGetZeroArgumentsPassed()
        {
            // Arrange
            var args = new string[0];
            
            // Assert
            Assert.Throws<TooFewArgumentsException>(() => Bootstrapper.Start(args));
        }
        
        [Fact]
        public void WhenPassedArgumentsShouldNotAcceptMultiple()
        {
            // Arrange
            var args = new string[] {"filename.csv", "some string"};
            
            // Assert
            Assert.Throws<TooManyArgumentsException>(() => Bootstrapper.Start(args));
        }
        
        [Fact]
        public void WhenRanShouldRejectNonCsvFile()
        {
            // Arrange
            var args = new string[] {"filename.bmp"};
            
            // Assert
            Assert.Throws<WrongFileTypeException>(() => Bootstrapper.Start(args));
        }
        
        [Fact]
        public void WhenPassedArgumentsShouldAcceptOnlyOne()
        {
            // Arrange
            var path = Path.Combine(Directory.GetCurrentDirectory(), "test-data.csv");
            var args = new string[] {path};

            // Act
            var exception = Record.Exception(() => Bootstrapper.Start(args));
            
            //Assert
            Assert.Null(exception);
        }
    }
}
