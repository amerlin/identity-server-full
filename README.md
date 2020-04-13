# Identity Server Demo

## Startup
Create a new Empty ASPNET Core 3.1 Project.

 * Add Identity Server 4 nuget packet
 * Edit Startup.cs to add IdentityServer 4 
 * Create Configuration/InMemoryConfig.cs

   InMemoryConfig.cs
   ```
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
                    AllowedScopes =  { IdentityServerConstants.StandardScopes.OpenId, "companyApi"}
                }
            };
        }

        //RETURN API RESOURCES
        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource>() { new ApiResource("companyApi", "description") };
       
    }

   ```


## Integration

 * Install dotnet Core Identity Server Templates (from command line)
    ```
    dotnet new --install "IdentityServer4.Templates"
    ```
 * Add Identity UI Template (in the project root folder)
    ```
    dotnet new is4ui
    ```
 * Add WebApi Resources

 
## Client Test
* Run the program
* Test authentication with PostMan

![Client Image](image001.JPG)


 * Login with in memory client