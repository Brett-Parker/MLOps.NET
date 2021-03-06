﻿using System;

namespace MLOps.NET.Exceptions
{
    /// <summary>
    /// Custom exception for failure to add package dependency
    /// </summary>
    public class AddPackageDependencyException : Exception
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="message"></param>
        public AddPackageDependencyException(string message) : base(message)
        {
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ex"></param>
        public AddPackageDependencyException(string message, Exception ex) : base(message, ex)
        {
        }
    }
}
