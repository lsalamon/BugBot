using MS.Debuggers.DbgEng;
using System.IO;
using System;
using MS.BugBot;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MS.BugBot.Tests
{
    /// <summary>This class contains parameterized unit tests for StreamOutputListener</summary>
    [TestClass]
    [PexClass(typeof(StreamOutputListener))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class StreamOutputListenerTest
    {

        /// <summary>Test stub for .ctor(Stream, LogOptions)</summary>
        [PexMethod]
        public StreamOutputListener ConstructorTest(Stream s, LogOptions options)
        {
            StreamOutputListener target = new StreamOutputListener(s, options);
            return target;
            // TODO: add assertions to method StreamOutputListenerTest.ConstructorTest(Stream, LogOptions)
        }

        /// <summary>Test stub for Dispose()</summary>
        [PexMethod]
        public void DisposeTest([PexAssumeUnderTest]StreamOutputListener target)
        {
            target.Dispose();
            // TODO: add assertions to method StreamOutputListenerTest.DisposeTest(StreamOutputListener)
        }

        /// <summary>Test stub for Output(DateTime, OutputFlags, String)</summary>
        [PexMethod]
        public void OutputTest(
            [PexAssumeUnderTest]StreamOutputListener target,
            DateTime when,
            OutputFlags flags,
            string text
        )
        {
            target.Output(when, flags, text);
            // TODO: add assertions to method StreamOutputListenerTest.OutputTest(StreamOutputListener, DateTime, OutputFlags, String)
        }
    }
}
