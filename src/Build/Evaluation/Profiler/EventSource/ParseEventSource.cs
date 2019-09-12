﻿using System;
using System.IO;
using System.Diagnostics.Tracing;


//
// Profiling for the function that parses an XML document into a ProjectRootElement.
//
namespace Microsoft.Build.Evaluation
{
    // /OnlyProviders=*Parse-Profiling
    [EventSource(Name = "Parse-Profiling")]
    public sealed class ParseEventSource : EventSource
    {
        #region Singleton instance

        // define the singleton instance of the event source
        public static ParseEventSource Log = new ParseEventSource();

        private ParseEventSource() { }

        #endregion

        #region Events and NonEvents

        /// <summary>
        /// Call this method to notify listeners of the specified event.
        /// </summary>
        /// <param name="info">Relevant information about where in the run of the progam it is.</param>
        public void Load(string info)
        {
            WriteEvent(1, info);
        }

        #endregion
    }
}
