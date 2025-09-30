# Roblox Website Recreation

Current Scopes:

- Frontend
- Backend
- Arbiters
- Moderation platform
- Analytics Platform and Stuff like that
- Server Deployer tools

Current Timelapses:

- 2016 (Main Recreation Target)
- 2013 (Just as an  starting point, works but i wont focus on it)

## Notes

- This is a work in progress reconstruction
- Many components are stubbed implementations
- The goal is to create a functional website that resembles the 2013 Roblox website

# Building Instructions
  
## Prerequisities

 1. Windows 10+
 2. Net SDK 4.8.1 Dev Pack or 4.7.2 and Older ones just in case
 3. Visual Studio 2022 (For Debugging)
 4. Asp Net 4.8 Enabled (Through Add or Remove Features Pop Up)

## Building And Running the Website

First you need to build the website and all assemblies, for that, just launch build.bat.

After its done you might want to actually run the website, here's some quick ways on how to do that:

Quick way:
 1. Run the launch.bat
 2. profit

Proper Way:
1. Open IIS Manager.
2. Create New Application Pool, name it Roblox or whatewer and set .NET CLR version to the latest one and set Pipeline Mode to Integrated and press Ok.
3. Create New Website named Roblox or whatewer you feel like and make it use the newly created Application Pool.
4. Set the physical path to the Roblox Website source code and set the port to whatewer you like.
5. Set the Host Name to whatewer you like too, try avoiding real websites maybe.
6. Start The Application Pool and the website itself and profit.
