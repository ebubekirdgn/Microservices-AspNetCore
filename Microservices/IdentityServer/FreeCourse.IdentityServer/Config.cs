// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;

namespace FreeCourse.IdentityServer
{
    public static class Config
    {
        public static IEnumerable<ApiResource> ApiResources => new ApiResource[]
        {
            new ApiResource("resource_catalog"){Scopes= {"catalog_fullpermission"} },
            new ApiResource("photo_stock_catalog"){Scopes= { "photo_stock_fullpermission" } },
            new ApiResource(IdentityServerConstants.LocalApi.ScopeName)
        };

        public static IEnumerable<IdentityResource> IdentityResources =>
                   new IdentityResource[]
                   {
                       new IdentityResources.Email(), //email
                       new IdentityResources.OpenId(),//sub
                       new IdentityResources.Profile(),
                       new IdentityResource(){Name = "roles",DisplayName = "Role", Description="Kullanıcı Rolleri",UserClaims=new[]{ "role"} },
                   };

        public static IEnumerable<ApiScope> ApiScopes =>
            new ApiScope[]
            {
                new ApiScope("catalog_fullpermission","Catalog API icin full erisim"),
                new ApiScope("photo_stock_fullpermission","Photo Stock API icin full erisim"),
                new ApiScope(IdentityServerConstants.LocalApi.ScopeName)
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "WebMvcClient",
                    ClientName = "Asp.Net Core MVC",
                    ClientSecrets = { new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    AllowedScopes= { "catalog_fullpermission", "photo_stock_fullpermission",IdentityServerConstants.LocalApi.ScopeName }
                },
                   new Client
                {
                    ClientId = "WebMvcClientForUser",
                    ClientName = "Asp.Net Core MVC",
                    AllowOfflineAccess = true,
                    ClientSecrets = { new Secret("secret".Sha256())},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                    AllowedScopes= { IdentityServerConstants.StandardScopes.OpenId, IdentityServerConstants.StandardScopes.Email, IdentityServerConstants.StandardScopes.Profile, IdentityServerConstants.StandardScopes.OfflineAccess, IdentityServerConstants.LocalApi.ScopeName, "roles" },
                    AccessTokenLifetime = 1*60*60, // 1 saat 
                    RefreshTokenExpiration = TokenExpiration.Absolute,
                    AbsoluteRefreshTokenLifetime= (int)(DateTime.Now.AddDays(60)-DateTime.Now).TotalSeconds, // 60 gün tutsun dedik.
                    RefreshTokenUsage = TokenUsage.ReUse
                }
            };
    }
}