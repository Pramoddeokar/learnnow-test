// <copyright file="BingImageService.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Azure.CognitiveServices.Search.ImageSearch;
    using Microsoft.Extensions.Options;
    using Microsoft.Teams.Apps.LearnNow.Common.Interfaces;
    using Microsoft.Teams.Apps.LearnNow.Models.Configuration;

    /// <summary>
    /// Service class for getting images from Bing image search API service.
    /// </summary>
    public class BingImageService : IImageProviderService
    {
        /// <summary>
        /// Bing Image height size
        /// </summary>
        public const int BingImageHeight = 200;

        /// <summary>
        /// Bing Image width size
        /// </summary>
        public const int BingImageWidth = 200;

        /// <summary>
        /// Bing cognitive service setting.
        /// </summary>
        private readonly IOptions<BingCognitiveServiceSettings> options;

        /// <summary>
        /// Image search client
        /// </summary>
        private readonly Lazy<Task<ImageSearchClient>> client;

        /// <summary>
        /// Initializes a new instance of the <see cref="BingImageService"/> class.
        /// </summary>
        /// <param name="options">Bing cognitive service settings</param>
        public BingImageService(IOptions<BingCognitiveServiceSettings> options)
        {
            this.options = options ?? throw new ArgumentNullException(nameof(options));
            this.client = new Lazy<Task<ImageSearchClient>>(() => this.InitializeClientAsync());
        }

        /// <summary>
        /// Method to get image URL's from Bing Image search API for given search text.
        /// </summary>
        /// <param name="searchQueryTerm">Find image URL's based on search query term.</param>
        /// <returns>Returns a collection of image URL from Bing Image API service.</returns>
        public async Task<IEnumerable<string>> GetSearchResultAsync(string searchQueryTerm)
        {
            var contentUrlResult = new List<string>();

            // Make the search request to the Bing Image API, and get the results.
            var client = await this.client.Value;
            var imageResults = await client.Images.SearchAsync(query: searchQueryTerm, height: BingImageHeight, width: BingImageWidth, safeSearch: "strict");

            foreach (var image in imageResults.Value)
            {
                // Get image URL's that starts with https, http image URL's are not getting rendered in Microsoft Teams Task Module.
                if (image.ContentUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    contentUrlResult.Add(image.ContentUrl);
                }
            }

            return contentUrlResult;
        }

        /// <summary>
        /// Method to initialize singleton Bing Image search API client object.
        /// </summary>
        /// <returns>Bing Image search client object.</returns>
#pragma warning disable CS1998 // Method is async doe lazy initialization.
        private async Task<ImageSearchClient> InitializeClientAsync()
#pragma warning restore CS1998 // Method is async doe lazy initialization.
        {
            return new ImageSearchClient(new ApiKeyServiceClientCredentials(this.options.Value.CognitiveServiceSubscriptionKey));
        }
    }
}