using IdentityServer4;
using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.API.Configs
{
    public static class Clients
    {
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId ="oauthClientId",
                    ClientName = "This is my first Client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = new List<Secret>{new Secret("secret".Sha256())},
                    AllowedScopes = new List<string>{ "customAPI.read" }
                },

                new Client
                {
                    ClientId = "765a10ef-8e67-443c-8727-50bdfdbf3b1b",
                    ClientName = "MVC Core Client APP",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        IdentityServerConstants.StandardScopes.Email,
                        "role",
                        "customAPI.write"
                    },
                    RedirectUris = new List<string>{ "https://localhost:44327/signin-oidc" },
                    PostLogoutRedirectUris = new List<string>{ "https://localhost:44327/" }
                }
            };
        }
    }
}
