﻿// <copyright file="AuthenticationMetadataController.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.LearnNow.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Controller for the authentication sign in data.
    /// </summary>
    [Route("api/authenticationMetadata")]
    public class AuthenticationMetadataController : ControllerBase
    {
        /// <summary>
        ///  Tenant id of the application.
        /// </summary>
        private readonly string tenantId;

        /// <summary>
        /// Client id of the application.
        /// </summary>
        private readonly string clientId;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationMetadataController"/> class.
        /// </summary>
        /// <param name="configuration">IConfiguration instance.</param>
        public AuthenticationMetadataController(IConfiguration configuration)
        {
            configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));

            this.tenantId = configuration["AzureAd:TenantId"];
            this.clientId = configuration["MicrosoftAppId"];
        }

        /// <summary>
        /// Get authentication consent URL.
        /// </summary>
        /// <param name="windowLocationOriginDomain">Window location origin domain.</param>
        /// <param name="loginHint">UPN value.</param>
        /// <returns>Consent URL.</returns>
        [HttpGet("consentUrl")]
        public string GetConsentUrl(
            [FromQuery] string windowLocationOriginDomain,
            [FromQuery] string loginHint)
        {
            var consentUrlComponentDictionary = new Dictionary<string, string>
            {
                ["redirect_uri"] = $"https://{windowLocationOriginDomain}/signin-simple-end",
                ["client_id"] = this.clientId,
                ["response_type"] = "id_token",
                ["response_mode"] = "fragment",
                ["scope"] = "https://graph.microsoft.com/User.Read openid profile",
                ["nonce"] = Guid.NewGuid().ToString(),
                ["state"] = Guid.NewGuid().ToString(),
                ["login_hint"] = loginHint,
            };
            var consentUrlComponentList = consentUrlComponentDictionary
                .Select(consentUrlComponent => $"{consentUrlComponent.Key}={HttpUtility.UrlEncode(consentUrlComponent.Value)}")
                .ToList();

            var consentUrlPrefix = $"https://login.microsoftonline.com/{this.tenantId}/oauth2/v2.0/authorize?";
            var consentUrlString = consentUrlPrefix + string.Join('&', consentUrlComponentList);

            return consentUrlString;
        }
    }
}