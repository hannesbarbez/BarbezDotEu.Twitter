﻿// Copyright (c) Hannes Barbez. All rights reserved.
// Licensed under the GNU General Public License v3.0

using System.Collections.Generic;
using System.Threading.Tasks;
using BarbezDotEu.MicroBlog.DTO;
using BarbezDotEu.Provider.Interfaces;

namespace BarbezDotEu.Twitter.Interfaces
{
    /// <summary>
    /// Defines a blueprint for a data provider that connects to and can call Twitter.com APIs.
    /// </summary>
    public interface ITwitterDataProvider : IPoliteProvider
    {
        /// <summary>
        /// Queries for occurences of the given topic found in tweets from the past 7 days.
        /// </summary>
        /// <param name="topic">The topic for which to query.</param>
        /// <returns>A list of <see cref="MicroBlogEntry"/> items corresponding to the given topic.</returns>
        Task<List<MicroBlogEntry>> GetRecentTweets(string topic);
    }
}
