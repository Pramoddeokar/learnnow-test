// <copyright file="ResourceDetailModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Infrastructure.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// A class which represents Resource detail model.
    /// </summary>
    public class ResourceDetailModel : Resource
    {
        /// <summary>
        /// Gets or sets resource votes.
        /// </summary>
        public IEnumerable<ResourceVote> Votes { get; set; }
    }
}