using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

       [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

                // arrange
            TacoParser tacoParser = new TacoParser();

            // act
            ITrackable actual = tacoParser.Parse(line);

            // assert
            Assert.NotNull(actual);
        }

        [Theory]
        [InlineData("34.071477, -84.296345, Taco Bell Alpharett...", 34.071477)]
        public void ShouldParseLatitude(string line, double expected)
        {
            // arrange
            TacoParser tacoParser = new TacoParser();

            // act
            ITrackable actual = tacoParser.Parse(line);

            // assert
            Assert.NotNull(actual);

            //TODO: Create a test ShouldParseLatitude
        }
    }
}
