// <copyright file="ISubjectRepository.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Infrastructure
{
    using System.Collections.Generic;
    using Microsoft.Teams.Apps.LearnNow.Infrastructure.Models;
    using Microsoft.Teams.Apps.LearnNow.Infrastructure.Repositories;

    /// <summary>
    /// Interface for handling operations related to Subject entity collection.
    /// </summary>
    public interface ISubjectRepository : IRepository<Subject>
    {
        /// <summary>
        /// Gets repository for handling operations on Subject entity.
        /// </summary>
        /// <param name="subjectsCollection"> List of subjects that needs to be deleted.</param>
        void DeleteSubjects(IEnumerable<Subject> subjectsCollection);
    }
}