using NUnit.Framework;
using System;

namespace ConsoleRPG.InputHandling.Tests
{
    [TestFixture]
    public class InputHandlerTests
    {
        [Test]
        public void TestArrows()
        {
            InputHandler testHandler = new InputHandler();
            testHandler.GetKey(ConsoleKey.LeftArrow);

            Assert.AreEqual("", testHandler.PreviousKey);
            Assert.AreEqual(ConsoleKey.LeftArrow.ToString(), testHandler.CurrentKey);

            testHandler.GetKey(ConsoleKey.RightArrow);
            Assert.AreEqual(ConsoleKey.LeftArrow.ToString(), testHandler.PreviousKey);
            Assert.AreEqual(ConsoleKey.RightArrow.ToString(), testHandler.CurrentKey);

            testHandler.GetKey(ConsoleKey.UpArrow);
            Assert.AreEqual(ConsoleKey.RightArrow.ToString(), testHandler.PreviousKey);
            Assert.AreEqual(ConsoleKey.UpArrow.ToString(), testHandler.CurrentKey);

            testHandler.GetKey(ConsoleKey.DownArrow);
            Assert.AreEqual(ConsoleKey.UpArrow.ToString(), testHandler.PreviousKey);
            Assert.AreEqual(ConsoleKey.DownArrow.ToString(), testHandler.CurrentKey);
        }
    }
}