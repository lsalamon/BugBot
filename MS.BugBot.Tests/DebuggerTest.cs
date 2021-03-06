using System.Threading.Tasks;
using MS.BugBot.Interfaces;
using System;
using MS.BugBot;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MS.BugBot.Tests
{
    /// <summary>This class contains parameterized unit tests for Debugger</summary>
    [TestClass]
    [PexClass(typeof(Debugger))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class DebuggerTest
    {

        /// <summary>Test stub for ConnectKernel(String, String[])</summary>
        [PexMethod]
        public Task<IDebugMonitor> ConnectKernelTest(string connStr, string[] symbols)
        {
            Task<IDebugMonitor> result = Debugger.ConnectKernel(connStr, symbols);
            return result;
            // TODO: add assertions to method DebuggerTest.ConnectKernelTest(String, String[])
        }

        /// <summary>Test stub for ConnectToDebugServer(String, String[])</summary>
        [PexMethod]
        public Task<IDebugMonitor> ConnectToDebugServerTest(string connStr, string[] symbols)
        {
            Task<IDebugMonitor> result = Debugger.ConnectToDebugServer(connStr, symbols);
            return result;
            // TODO: add assertions to method DebuggerTest.ConnectToDebugServerTest(String, String[])
        }

        /// <summary>Test stub for CreateUserMode(String[])</summary>
        [PexMethod]
        public Task<IDebugMonitor> CreateUserModeTest(string[] symbols)
        {
            Task<IDebugMonitor> result = Debugger.CreateUserMode(symbols);
            return result;
            // TODO: add assertions to method DebuggerTest.CreateUserModeTest(String[])
        }
    }
}
