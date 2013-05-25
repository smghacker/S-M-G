using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalendarRefactoredNS;

namespace CalendarTests
{
    [TestClass]
    public class CommandTests
    {
        [TestMethod]
        [TestCategory("CommandParseTests")]
        public void CommandParseValidDataTest()
        {
            Command newCommand = Command.Parse("AddEvent 2001-01-01T10:30:00 | PARTY");
        }

        [TestMethod]
        [TestCategory("CommandParseTests")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void CommandParseInvalidDataTest()
        {
            Command newCommand = Command.Parse("AddEvent2001-01-01T10:30:00|PARTY");
        }

        [TestMethod]
        [TestCategory("CommandParseTests")]
        public void CommandParseAddEventTest()
        {
            Command newCommand = Command.Parse("AddEvent 2001-01-01T10:30:00 | PARTY | Party");

            Assert.AreEqual("AddEvent", newCommand.CommandName);
        }

        [TestMethod]
        [TestCategory("CommandParseTests")]
        public void CommandParseDeleteEventsTest()
        {
            Command newCommand = Command.Parse("DeleteEvent PARTY");

            Assert.AreEqual("PARTY", newCommand.Arguments[0]);
        }

        [TestMethod]
        [TestCategory("CommandParseTests")]
        public void CommandParseListEventsTest()
        {
            Command newCommand = Command.Parse("ListEvents 2000-01-01T01:00:01 | 2");

            Assert.AreEqual("2", newCommand.Arguments[1]);
        }
    }
}
