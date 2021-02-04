// <copyright file="LearningModuleDetailModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Infrastructure.Models
{
    using System.Collections.Generic;

    /// <summary>
    /// A class which represents learning module detail model.
    /// </summary>
    public class LearningModuleDetailModel : LearningModule
    {
        /// <summary>
        /// Gets or sets module votes.
        /// </summary>
        public IEnumerable<LearningModuleVote> Votes { get; set; }

        /// <summary>
        /// Gets or sets module resource mappings.
        /// </summary>
        public IEnumerable<ResourceModuleMapping> ResourceModuleMappings { get; set; }
    }
}