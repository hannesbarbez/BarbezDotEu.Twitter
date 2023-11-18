// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System;

namespace BarbezDotEu.Twitter.Exceptions
{
    [Serializable]
    internal class TwitterDataProviderException : Exception
    {
        /// <inheritdoc/>
        public TwitterDataProviderException()
        {
        }

        /// <inheritdoc/>
        public TwitterDataProviderException(string message) : base(message)
        {
        }
    }
}
