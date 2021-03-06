using System.Runtime.Serialization;
using System;
using MS.BugBot;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MS.BugBot.Tests
{
    /// <summary>This class contains parameterized unit tests for DebugMonitorException</summary>
    [TestClass]
    [PexClass(typeof(DebugMonitorException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DebugMonitorExceptionTest
    {

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public DebugMonitorException ConstructorTest(string message)
        {
            DebugMonitorException target = new DebugMonitorException(message);
            return target;
            // TODO: add assertions to method DebugMonitorExceptionTest.ConstructorTest(String)
        }

        /// <summary>Test stub for .ctor(String, String)</summary>
        [PexMethod]
        public DebugMonitorException ConstructorTest01(string actionName, string message)
        {
            DebugMonitorException target = new DebugMonitorException(actionName, message);
            return target;
            // TODO: add assertions to method DebugMonitorExceptionTest.ConstructorTest01(String, String)
        }

        /// <summary>Test stub for .ctor(String, Exception)</summary>
        [PexMethod]
        public DebugMonitorException ConstructorTest02(string message, Exception inner)
        {
            DebugMonitorException target = new DebugMonitorException(message, inner);
            return target;
            // TODO: add assertions to method DebugMonitorExceptionTest.ConstructorTest02(String, Exception)
        }

        /// <summary>Test stub for GetObjectData(SerializationInfo, StreamingContext)</summary>
        [PexMethod]
        public void GetObjectDataTest(
            [PexAssumeUnderTest]DebugMonitorException target,
            SerializationInfo info,
            StreamingContext context
        )
        {
            target.GetObjectData(info, context);
            // TODO: add assertions to method DebugMonitorExceptionTest.GetObjectDataTest(DebugMonitorException, SerializationInfo, StreamingContext)
        }
    }
}
