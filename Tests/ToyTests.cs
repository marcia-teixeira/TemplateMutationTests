using FluentAssertions;
using Template;
using Xunit;

namespace Tests
{
    public class ToyTests
    {
        [Fact]
        public void ShouldReturnTrueWhenAgeIsRecomendade()
        {
            var result = new Toy().RecomendadeAge(4);
            result.Should().BeTrue();
        }

        [Fact]
        public void ShouldReturnTrueWhenAgeIsNotRecomendade()
        {
            var result = new Toy().RecomendadeAge(15);
            result.Should().BeFalse();
        }
    }
}