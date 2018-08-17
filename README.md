# SectorLister

Simple system name generator for Elite Dangerous.

This tool generates an "ImportStars.txt" file that can be loaded into ED to pretend you've visited a whole sub-sector.
Useful when strip-mining or strip-hunting a sub-sector and you want to remove systems *not* in the sub-sector you're searching.

## Instructions for single sector filtering

1. Enter name of sector you wish to add to your "visited stars" list
1. Leave "Isolate cube ?" unticked
1. Enter start/end system numbers
1. Select destination directory  to save the "ImportStars.txt" file
1. If required, check "Append to file" to add this list to any existing "ImportStars.txt" file
1. Click "Generate"
1. Repeat from (1) as necessary
1. Now move "ImportStars.txt" into the same directory as "VisitedStarsCache.dat" ... this is usually C:\Users\\<username>\AppData\Local\Frontier Developments\Elite Dangerous\117531 but that last number might change per user ???
1. Now either start Elite from the Desktop, or if you're already in-game, log out to the Main Menu
1. Chose "Start"
1. The file will now be processed (my rough test is about 60 entries per second)

## Instructions for isolating a system

1. Enter name of sector you want to isolate
1. Check "Isolate cube ?"
1. Select what you want to add to your "visited stars" list
   - Parents : add the sector's parents, grand-parents, etc
   - Children : add all the sectors contained within the target sector
   - Neighbours : add all immediate neighbours of the target sector
1. Enter start/end system numbers
1. Select destination directory  to save the "ImportStars.txt" file
1. If required, check "Append to file" to add this list to any existing "ImportStars.txt" file
1. Click "Generate"
1. [jump to 8 above]

**Warning** : isolating a 'D' sector with parents, children and neighbours will generate a list of 249 sectors.
If you set each of these to have (say) 15000 systems, you'll end up with ~3.7 million systems the game needs to import.

**This will take about 17 hours to import !!**

I might look at adding a feature to split the output file into smaller sizes, which you'd then have to rename / copy / import one at a time.

## Acknowledgements

* Many thanks to Chiggy for the initial script.
* Thanks to Jackie Silver for some epic work in understanding how the naming scheme works in the first place !!  See [this thread](https://forums.frontier.co.uk/showthread.php/196297) for more info.
* And, of course, Frontier Developments for making such a cool game.
