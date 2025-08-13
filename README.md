# Roblox Website (2013)

This is a recreation of the Roblox website from 2013.

## Project Structure

The project is organized into several key directories:

- `Website/Source` - Contains the main website source code
- `Website/Source/Controllers` - MVC controllers
- `Website/Source/Entities` - Domain entities
- `Website/Source/Factories` - Factory classes and interfaces
- `Website/Source/Web` - Web-specific components

## Implemented Components

We have implemented or stubbed the following components to resolve build errors:

1. **Account System**
   - `Account` entity with related properties and methods
   - `AccountStatus` entity with CRUD operations
   - `IAccount` interface

2. **User System**
   - `UserFactory` implementation
   - `IUserFactory` interface
   - `IUserEmail` interface and implementation
   - `IUserEmailFactory` interface and implementation
   - `ICredentialValidator` interface and implementation

3. **Role System**
   - `Role` entity implementing `IRoleSetEntity`
   - `RoleSet` entity implementing `IRoleSet`
   - `IRoleSetReader` interface and implementation
   - `IRoleSetValidator` interface (stubbed)

4. **Web Components**
   - `Maintenance` class
   - `Showcase` and `ShowcaseItem` entities
   - `Asset` entity with `IAsset` interface
   - `ReplicatedCssControllerBase` controller base class

## Build Instructions

1. Open the solution in Visual Studio
2. Restore NuGet packages if needed
3. Build the solution

Alternatively, you can run the `build.bat` script from the command line.

## Notes

- This is a work in progress reconstruction
- Many components are stubbed implementations
- The goal is to create a functional website that resembles the 2013 Roblox website
