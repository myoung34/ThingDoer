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
            const string str = "asdf";
            str.AddFoo().ReverseThing().Should().Be("ooffdsa");
        }


        [Test]
        public void AppendFooAndReverseChainTwo()
        {
            const string str = "wat";
            str.AddFoo().ReverseThing().Should().Be("ooftaw");
        }

        [Test]
        public void ReverseChainAndAppendFoo()
        {
            const string str = "wat";
            str.ReverseThing().AddFoo().Should().Be("tawfoo");
        }

        [Test]
        public void SwapCase()
        {
            const string str = "My Dog";
            str.SwapCase().Should().Be("mY dOG");
        }

        [Test]
        public void SwapCaseAddFoo()
        {
            const string str = "My Dog";
            str.SwapCase().AddFoo().Should().Be("mY dOGfoo");
        }

        [Test]
        public void AddWat()
        {
            const string str = "asdf";
            str.AddWat().Should().Be("asdfwat");
        }

        [Test]
        public void SwapCaseAddFooAddWat()
        {
            const string str = "My Dog";
            str.SwapCase().AddFoo().AddWat().Should().Be("mY dOGfoowat");
        }

        [Test]
        public void AddWatSwapCaseAddFoo()
        {
            const string str = "asdf";
            str.AddWat().SwapCase().AddFoo().Should().Be("ASDFWATfoo");
        }

        [Test]
        public void PrecedeZero()
        {
            const string str = "asdf";
            str.PrecedeZero().Should().Be("0asdf");
        }
    }
}
