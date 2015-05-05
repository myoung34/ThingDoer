using NUnit.Framework;
using FluentAssertions;
using ThingDoer.API;

namespace ThingDoer._specs
{
    [TestFixture]
    class StringTests
    {
        [Test]
        public void ReverseString()
        {
            const string str = "foo";
            str.ReverseThing().Should().Be("oof");
        }

        [Test]
        public void AppendFoo()
        {
            const string str = "wat";
            str.AddFoo().Should().Be("watfoo");
        }

        [Test]
        public void AppendFooAndReverseChain()
        {
            const string str = "wat";
            str.AddFoo().ReverseThing().Should().Be("ooftaw");
        }

    }
}
