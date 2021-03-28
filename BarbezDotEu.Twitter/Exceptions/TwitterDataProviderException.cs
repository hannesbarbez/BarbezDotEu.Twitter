// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;
using System.Runtime.Serialization;

namespace BarbezDotEu.Twitter.Exceptions
{
    [Serializable]
    internal class TwitterDataProviderException : Exception
    {
        public TwitterDataProviderException()
        {
        }

        public TwitterDataProviderException(string message) : base(message)
        {
        }

        public TwitterDataProviderException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TwitterDataProviderException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
