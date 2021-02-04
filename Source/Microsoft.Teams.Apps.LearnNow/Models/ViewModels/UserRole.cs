// <copyright file="UserRole.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Models
{
    /// <summary>
    /// Model to handle user role details.
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// Gets or sets a value indicating whether user is administrator or not.
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether user is teacher or not.
        /// </summary>
        public bool IsTeacher { get; set; }
    }
}