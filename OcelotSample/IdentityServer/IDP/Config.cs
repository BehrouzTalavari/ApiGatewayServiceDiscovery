// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4;
using IdentityServer4.Models;

using System.Collections.Generic;
using System.Linq;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("HumanResource","نیروی انسانی"),
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            { 
               // interactive ASP.NET Core MVC client
                new Client
                {
                    ClientId = "mvc",

                    ClientName = "MVC Application",

                    AllowedGrantTypes = GrantTypes.Hybrid,

                    AllowRememberConsent=false,

                    RequirePkce=false,

                    ClientSecrets = { new Secret("secret".Sha256()) },

                    RedirectUris = { "https://localhost:5002/signin-oidc" },

                    PostLogoutRedirectUris = { "https://localhost:5002/signout-callback-oidc" },

                    RequireConsent=true,

                    // where to redirect to after login

                    // where to redirect to after logout

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "HumanResource"
                    }
                },
                new Client
                {
                    ClientId = "HumanResourceClient",

                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    ClientSecrets ={new Secret("secret".Sha256())},

                    AllowedScopes = { "HumanResource" }
                }
            };


        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("HumanResource", "نیروی انسانی API"),
        };
    }
}