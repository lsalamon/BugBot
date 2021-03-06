using MS.Debuggers.DbgEng;
using MS.BugBot.Interfaces;
using System;
using MS.BugBot;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MS.BugBot.Tests
{
    /// <summary>This class contains parameterized unit tests for SimpleTriggerListener</summary>
    [TestClass]
    [PexClass(typeof(SimpleTriggerListener))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class SimpleTriggerListenerTest
    {

        /// <summary>Test stub for .ctor(DebugTrigger, String[])</summary>
        [PexMethod]
        public SimpleTriggerListener ConstructorTest(DebugTrigger triggerType, string[] debugCommands)
        {
            SimpleTriggerListener target = new SimpleTriggerListener(triggerType, debugCommands);
            return target;
            // TODO: add assertions to method SimpleTriggerListenerTest.ConstructorTest(DebugTrigger, String[])
        }

        /// <summary>Test stub for HandleEvent(DebugTrigger, DebuggerEventArgs, IDebugContext)</summary>
        [PexMethod]
        public void HandleEventTest(
            [PexAssumeUnderTest]SimpleTriggerListener target,
            DebugTrigger triggerType,
            DebuggerEventArgs eventArgs,
            IDebugContext context
        )
        {
            target.HandleEvent(triggerType, eventArgs, context);
            // TODO: add assertions to method SimpleTriggerListenerTest.HandleEventTest(SimpleTriggerListener, DebugTrigger, DebuggerEventArgs, IDebugContext)
        }

        /// <summary>Test stub for HandlesEvent(DebugTrigger, DebuggerEventArgs)</summary>
        [PexMethod]
        public bool HandlesEventTest(
            [PexAssumeUnderTest]SimpleTriggerListener target,
            DebugTrigger triggerType,
            DebuggerEventArgs eventArgs
        )
        {
            bool result = target.HandlesEvent(triggerType, eventArgs);
            return result;
            // TODO: add assertions to method SimpleTriggerListenerTest.HandlesEventTest(SimpleTriggerListener, DebugTrigger, DebuggerEventArgs)
        }
    }
}
