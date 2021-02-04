// <copyright file="UserDetail.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Models
{
    using System;

    /// <summary>
    /// Handles author settings for filter.
    /// </summary>
    public class UserDetail
    {
        /// <summary>
        /// Gets or sets user's Azure Active Directory id.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets user name.
        /// </summary>
        public string DisplayName { get; set; }
    }
}
