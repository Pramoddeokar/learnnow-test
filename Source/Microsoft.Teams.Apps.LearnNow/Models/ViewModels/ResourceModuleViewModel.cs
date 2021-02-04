// <copyright file="ResourceModuleViewModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Models
{
    using System;
    using Microsoft.Teams.Apps.LearnNow.Helpers.CustomValidations;

    /// <summary>
    /// Class contains resource learning module details.
    /// </summary>
    public class ResourceModuleViewModel
    {
        /// <summary>
        /// Gets or sets resource id.
        /// </summary>
        [GuidValidation]
        public Guid ResourceId { get; set; }

        /// <summary>
        /// Gets or sets learning module id.
        /// </summary>
        [GuidValidation]
        public Guid LearningModuleId { get; set; }
    }
}