// <copyright file="SecurityGroupSettings.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Models.Configuration
{
    /// <summary>
    /// Provides application settings related to security groups.
    /// </summary>
    public class SecurityGroupSettings
    {
        /// <summary>
        /// Gets or sets group id of teacher's security group.
        /// </summary>
        public string TeacherSecurityGroupId { get; set; }

        /// <summary>
        /// Gets or sets group id of administrators security group.
        /// </summary>
        public string AdminGroupId { get; set; }

        /// <summary>
        /// Gets or sets groupd id of moderator group.
        /// </summary>
        public string ModeratorGroupId { get; set; }
    }
}
