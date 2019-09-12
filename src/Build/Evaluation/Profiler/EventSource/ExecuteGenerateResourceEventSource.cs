﻿using System;
using System.IO;
using System.Diagnostics.Tracing;


//
// Main entrypoint for the GenerateResource task.
//
namespace Microsoft.Build.Evaluation
{
    // /OnlyProvider=*ExecuteGeneralResource-Profiling
    [EventSource(Name = "ExecuteGeneralResource-Profiling")]
    public sealed class ExecuteGeneralResourceEventSource : EventSource
    {
        #region Singleton instance

        // define the singleton instance of the event source
        public static ExecuteGeneralResourceEventSource Log = new ExecuteGeneralResourceEventSource();

        private ExecuteGeneralResourceEventSource() { }

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
