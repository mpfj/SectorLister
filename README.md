# SectorLister

Simple system name generator for Elite Dangerous.

This tool generates an "ImportStars.txt" file that can be loaded into ED to pretend you've visited a whole sub-sector.
Useful when strip-mining or strip-hunting a sub-sector and you want to remove systems *not* in the sub-sector you're searching.

## Simple instructions

1. Enter System name
2. Enter start/end system numbers
3. Select destination directory  to save the "ImportStars.txt" file
4. If required, check "Append to file" to add this list to any existing "ImportStars.txt" file
5. Click "Generate"
6. Repeat from (1) as necessary
7. Now move "ImportStars.txt" into the same directory as "VisitedStarsCache.dat" ... this is usually C:\Users\\<username>\AppData\Local\Frontier Developments\Elite Dangerous\117531 but that last number might change per user ???
8. Now either start Elite from the Desktop, or if you're already in-game, log out to the Main Menu
9. Chose "Start"
10. The file will now be processed (my rough test is about 60 entries per second)

## Acknowledgements

* Many thanks to Chiggy for the initial script.
* And, of course, Frontier Developments for making such a cool game.
