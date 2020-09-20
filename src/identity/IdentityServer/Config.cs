// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            { 
                new IdentityResources.OpenId()
            };

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope>
            {
                new ApiScope("GasApi", "Gas company api"),
                new ApiScope("GasApi1", "Gas company api")
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                new Client
                {
                    ClientId = "BlazorClient",

                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,

                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("blazorsecret1".Sha256())
                    },

                    // scopes that client has access to
                    AllowedScopes = { "GasApi"},

                    //todo: enabled for localdev testing, have to be removed
                    AllowedCorsOrigins = new List<string>
                    {
                        "https://127.0.0.1:7001",
                        "https://localhost:7001"
                    }
                }
            };
    }
}