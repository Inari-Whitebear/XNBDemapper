# Easier usage version: https://github.com/Inari-Whitebear/SimpleXNBDemapper

* Install XNA Game Studio
* Download xTile Engine from http://tide.codeplex.com/releases
* Place the dlls into ./XNBDemapper/XNBDemapper/ and ./XNBDemapper/XNBDemapperContent/
* You might have to rightclick on the DLLs, choose Properties and check the Unblock checkbox on the bottom

To convert map to xnb:
* Add the map (.tide) to the content project (and place in XNBDemapperContent project folder)
* Place the png tileset files in that folder too (don't have to add them to the project)
* Make sure you set the Content Importer to tIDE Map Importer
* Rebuild Solution
* A xnb file should pop up in ./XNBDemapper/XNBDemapper/Content

To convert xnb to map:
* Compile or use precompiled exe
* Go to the directory of the executable
* Place the xnb into ./Content and run the executable, a .tbin file should pop up in ./ContentOut
* Open the tBin File in the tIDE Editor (Downloaded at http://tide.codeplex.com/releases ) (You need to have the tilesets used as png files in the same folder as the tBin file, it will tell you which tileset is missing otherwise and can't open the map)

To get the png files use XnbNode or the like to decode them from the game's xnbs

Just pasted some crap tiles into the house: http://akari.in/pinky_EDDK6