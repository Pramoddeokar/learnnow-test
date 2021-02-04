// <copyright file="ResourceMapperTest.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Tests.Mappers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Teams.Apps.LearnNow.Infrastructure.Models;
    using Microsoft.Teams.Apps.LearnNow.Infrastructure.Repositories;
    using Microsoft.Teams.Apps.LearnNow.ModelMappers;
    using Microsoft.Teams.Apps.LearnNow.Models;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The ResourceMapperTest contains all the test cases for the resource model mappers operations.
    /// </summary>
    [TestClass]
    public class ResourceMapperTest
    {
        private LearnNowContext learnNowContext;
        private ResourceMapper resourceMapper;
        private ResourceViewModel resourceViewModel;
        private Resource resourceEntityModel;

        /// <summary>
        /// Method for testing PatchAndMapToDTO method from mapper.
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            this.learnNowContext = new LearnNowContext();
            this.resourceMapper = new ResourceMapper(
                this.learnNowContext);
            this.resourceViewModel = new ResourceViewModel()
            {
                Id = Guid.NewGuid(),
                GradeId = Guid.NewGuid(),
                Title = "Test subject",
                Description = "Test description",
                ImageUrl = "Https://test.jpg",
                ResourceType = 1,
            };
            this.resourceEntityModel = new Resource()
            {
                Id = Guid.NewGuid(),
                GradeId = Guid.NewGuid(),
                Title = "Test subject",
                Description = "Test description",
                ImageUrl = "Https://test.jpg",
                ResourceType = 1,
                UpdatedBy = Guid.NewGuid(),
            };
        }

        /// <summary>
        ///  Method for testing MapToDTO method from mapper.
        /// </summary>
        [TestMethod]
        public void MapToDTOTest()
        {
            // ARRANGE
            var resourceViewModel = this.resourceViewModel;

            // ACT
            var result = this.resourceMapper.MapToDTO(resourceViewModel, Guid.NewGuid());

            // ASSERT
            Assert.AreEqual(result.Id, resourceViewModel.Id);
            Assert.AreEqual(result.Title, resourceViewModel.Title);
            Assert.AreEqual(result.Description, resourceViewModel.Description);
            Assert.AreEqual(result.ImageUrl, resourceViewModel.ImageUrl);
            Assert.AreEqual(result.ImageUrl, resourceViewModel.ImageUrl);
        }

        /// <summary>
        /// Method for testing MapToViewModel method from mapper.
        /// </summary>
        [TestMethod]
        public void MapToViewModelTest()
        {
            // ARRANGE
            var resourceEntityModel = this.resourceEntityModel;

            var userDetail = new UserDetail()
            {
                UserId = resourceEntityModel.UpdatedBy,
                DisplayName = "Test DisplayName",
            };

            IEnumerable<UserDetail> useDetail = new List<UserDetail>() { userDetail };

            // ACT
            var result = this.resourceMapper.MapToViewModel(resourceEntityModel, useDetail);

            // ASSERT
            Assert.AreEqual(result.Id, resourceEntityModel.Id);
            Assert.AreEqual(result.Title, resourceEntityModel.Title);
            Assert.AreEqual(result.Description, resourceEntityModel.Description);
            Assert.AreEqual(result.ImageUrl, resourceEntityModel.ImageUrl);
        }

        /// <summary>
        /// Method for testing PatchAndMapToDTO method from mapper.
        /// </summary>
        [TestMethod]
        public void PatchAndMapToDTOTest()
        {
            // ARRANGE
            var resourceViewModel = this.resourceViewModel;

            // ACT
            var result = this.resourceMapper.PatchAndMapToDTO(resourceViewModel, Guid.NewGuid());

            // ASSERT
            Assert.AreEqual(result.Id, resourceViewModel.Id);
            Assert.AreEqual(result.Title, resourceViewModel.Title);
            Assert.AreEqual(result.Description, resourceViewModel.Description);
            Assert.AreEqual(result.ImageUrl, resourceViewModel.ImageUrl);
        }

        /// <summary>
        /// Method for testing PatchAndMapToViewModel method from mapper.
        /// </summary>
        [TestMethod]
        public void PatchAndMapToViewModelTest()
        {
            // ARRANGE
            var resourceEntityModel = this.resourceEntityModel;

            var userDetail = new UserDetail()
            {
                UserId = Guid.NewGuid(),
                DisplayName = "Test DisplayName",
            };

            IEnumerable<UserDetail> useDetail = new List<UserDetail>() { userDetail };

            var resourceVote = new ResourceVote()
            {
                Id = Guid.NewGuid(),
                ResourceId = resourceEntityModel.Id,
                UserId = resourceEntityModel.CreatedBy,
            };
            IEnumerable<ResourceVote> resourceVotes = new List<ResourceVote>() { resourceVote };

            // ACT
            var result = this.resourceMapper.PatchAndMapToViewModel(resourceEntityModel, Guid.NewGuid(), resourceVotes, useDetail);

            // ASSERT
            Assert.AreEqual(result.Id, resourceEntityModel.Id);
            Assert.AreEqual(result.Title, resourceEntityModel.Title);
            Assert.AreEqual(result.Description, resourceEntityModel.Description);
            Assert.AreEqual(result.ImageUrl, resourceEntityModel.ImageUrl);
        }
    }
}