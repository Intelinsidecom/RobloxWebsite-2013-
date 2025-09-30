# Roblox Website (2013)

Warning: This repo is Vide coded, i let you hate for it

This is a recreation of the Roblox website from 2013.

## Notes

- This is a work in progress reconstruction
- Many components are stubbed implementations
- The goal is to create a functional website that resembles the 2013 Roblox website

## Build Instructions

Visual Studio way:
    Open the solution in Visual Studio,
    Restore NuGet packages if needed,
    Build the solution,
    Profit.

Terminal way:
    Launch build.bat,
    Profit.

## Running the website

# Prerequisities

 1. Windows 10+
 2. Net SDK 4.8.1 Dev Pack or 4.7.2 and Older ones just in case
 3. Visual Studio 2022 (For Debugging)
 4. Asp Net 4.8 Enabled (Through Add or Remove Features Pop Up)

# In order to actually run this website and use it you will first need to check if you have everything to run it properly (Step 1)
    Quick way:
    Run the launch.bat,
    profit.

    Proper Way:
    1. Open IIS Manager.
    2. Create New Application Pool, name it Roblox or whatewer and set .NET CLR version to the latest one and set Pipeline Mode to Integrated and press Ok.
    3. Create New Website named Roblox or whatewer you feel like and make it use the newly created Application Pool.
    4. Set the physical path to the Roblox Website source code and set the port to whatewer you like.
    5. Set the Host Name to whatewer you like too, try avoiding real websites maybe.
    6. Start The Application Pool and the website itself and profit.
