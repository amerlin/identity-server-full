using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer4;
using IdentityServer4.Models;       //identity namespace for model
using IdentityServer4.Test;         //identity namespace for test users

namespace IdentityServerDemo.Configuration
{
    public static class InMemoryConfig
    {
        //RETURN IN MEMORY IDENTITY RESOURCES
        public static IEnumerable<IdentityResource> GetIdentityResources() =>
            new List<IdentityResource>()
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };

        //RETURN IN MEMORY USERS
        public static List<TestUser> GetUsers() =>
            new List<TestUser>()
            {
                new TestUser()
                {
                    SubjectId = "fdsfsdfsd",
                    Username = "Andrea",
                    Password = "AndreaPassword",
                    Claims = new List<Claim>()
                    {
                        new Claim("given_name", "Andrea"),
                        new Claim("family_name", "Merlin")
                    }
                },
                new TestUser()
                {
                    SubjectId = "ggjflgdlgdfljg",
                    Username = "Visual",
                    Password = "VisualPassword",
                    Claims = new List<Claim>()
                    {
                        new Claim("given_name", "Visual"),
                        new Claim("family_name", "Studio")
                    }
                }
            };

        //RETURN IN MEMORY CLIENTS
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>()
            {
                new Client()
                {
                    ClientId = "company-employee",
                    ClientSecrets = new[] {new Secret("demopassword".Sha512())},
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPasswordAndClientCredentials,   //flow types
                    AllowedScopes =  { IdentityServerConstants.StandardScopes.OpenId}
                }
            };
        }


}



    

}
