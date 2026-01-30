<p align="center">
<img alt="GitHub Repo Size" src="https://img.shields.io/github/repo-size/Intelinsidecom/Roblox-Website">
<img alt="GitHub Release" src="https://img.shields.io/github/v/release/Intelinsidecom/Roblox-Website?color=violet">
<img alt="GitHub Last Commit" src="https://img.shields.io/github/last-commit/Intelinsidecom/Roblox-Website/2016">
</p>

![Roblox Website Banner](Extras/RobloxWebsiteBanner.png)
# Roblox Website Recreation

Originally made by Brent with some code from Roblox Testing site Stacktraces, Leaked assemblies, tried to be fixed by ErringPaladin (Brr Brr Patapim) and was finished to enough to run state by Intel

!!! All code is just recreations of the backend and frontend and is all similiarities to the actual code at Roblox is just an coincidence !!!

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

## Backstory

I wanted to make my own Roblox like Website and more and using other ones like ECS and those cheap in-php written revival source codes wasnt perfect for many reasons like security issues, unorganised code and just the fact they dont feel roblox at all. Thats why i decided to make my own that backend and frontend for my own revival and i want to make it special.
I decided to use the same systems Roblox have used or maybe still use like ASP Net websites and recreate the same backend and frontend sites they might have used back then and make them as accurate as to roblox ones.

# Building Instructions
  
## Prerequisities

 1. Windows 10+
 2. Net SDK 4.8.1 Dev Pack or 4.7.2 and Older ones just in case
 3. Visual Studio 2022 (For Debugging)
 4. Asp Net 4.8 Enabled (Through Add or Remove Features Pop Up)

## Building And Running the Website

First you need to build the website and all assemblies, for that, just launch build.cmd.

After its done you might want to actually run the website, here's some quick ways on how to do that:

Quick way:
 1. Run the launch.cmd
 2. profit

Proper Way:
1. Open IIS Manager.
2. Create New Application Pool, name it Roblox or whatewer and set .NET CLR version to the latest one and set Pipeline Mode to Integrated and press Ok.
3. Create New Website named Roblox or whatewer you feel like and make it use the newly created Application Pool.
4. Set the physical path to the Roblox Website source code and set the port to whatewer you like.
5. Set the Host Name to whatewer you like too, try avoiding real websites maybe.
6. Start The Application Pool and the website itself and profit.
