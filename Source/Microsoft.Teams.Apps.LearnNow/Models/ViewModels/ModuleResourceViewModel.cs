// <copyright file="ModuleResourceViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Models
{
    using System.Collections.Generic;
    using Microsoft.Teams.Apps.LearnNow.Infrastructure.Models;

    /// <summary>
    /// Class contains learning module resource details.
    /// </summary>
    public class ModuleResourceViewModel
    {
        /// <summary>
        /// Gets or sets learning module.
        /// </summary>
        public LearningModuleViewModel LearningModule { get; set; }

        /// <summary>
        /// Gets or sets learning module associated resource collection.
        /// </summary>
        public IEnumerable<ResourceViewModel> Resources { get; set; }
    }
}