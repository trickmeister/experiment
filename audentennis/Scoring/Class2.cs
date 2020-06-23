using System;
using FluentAssertions;
using NUnit.Framework;

namespace Scoring
{
    public class Class2
    {
        public string Name { get; set; }

        public void ss()
        {
            Name.Should().Be("m");
        }
    }

    [TestFixture]
    public class Class1
    {
        [Test]
        public void mmm()
        {
            var class2 = new Class2 { Name = "m" };
            class2.Name.Should().Be("m");
            Assert.True(true);

        }
    }
}
