# Identity Server Demo

## Startup
Create a new Empty ASPNET Core 3.1 Project.

 * Add Identity Server 4 nuget packet
 * Edit Startup.cs to add IdentityServer 4 
 * Create Configuration/InMemoryConfig.cs

## Integration

 * Install dotnet Core Identity Server Templates (from command line)
    ```
    dotnet new --install "IdentityServer4.Templates"
    ```
 * Add Identity UI Template (in the project root folder)
    ```
    dotnet new is4ui
    ```
 
## Client Test
* Run the program
* Test authentication with PostMan

![Client Image](image001.JPG)


 * Login with in memory client