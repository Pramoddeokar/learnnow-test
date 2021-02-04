// <copyright file="MustBeTeacherOrAdminUserPolicyRequirement.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Authentication.AuthenticationPolicy.AuthenticationPolicy
{
    using Microsoft.AspNetCore.Authorization;

    /// <summary>
    /// This authorization class implements the marker interface
    /// <see cref="IAuthorizationRequirement"/> to check if user meets security group specific requirements
    /// for accessing resources.
    /// </summary>
    public class MustBeTeacherOrAdminUserPolicyRequirement : IAuthorizationRequirement
    {
    }
}
