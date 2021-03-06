﻿#region

using System;

#endregion

namespace Tumbaga.IoC
{
    public class IocException : Exception
    {
        public IocException()
        {
        }

        public IocException(string message) : base(message)
        {
        }

        public IocException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
