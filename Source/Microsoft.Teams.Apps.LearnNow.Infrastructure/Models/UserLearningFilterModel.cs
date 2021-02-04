// <copyright file="UserLearningFilterModel.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Infrastructure.Models
{
    using System;

    /// <summary>
    /// This class handles User Learning filter.
    /// </summary>
    public class UserLearningFilterModel
    {
        /// <summary>
        /// Gets or sets user's Azure Active Directory id.
        /// </summary>
        public Guid UserObjectId { get; set; }

        /// <summary>
        /// Gets or sets SearchText.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to get resource or module from user saved list.
        /// </summary>
        public bool IsSaved { get; set; }
    }
}