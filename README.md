# Dead Space 2 PC Save Editor

## Warning!

Remember to make a backup before modifying any save file.

Save files are located in `%USERPROFILE%\Documents\EA Games\Dead Space 2\`. Number in filename represents slot number in game. [^1] 

## Key Features

* Change Credits and Power Nodes amount
* Activate Infinite Ammo and Stasis
* Select active Suit
* Edit Inventory, Safe and Shop items
* Unlock every Suit and Weapon (including all DLC and Bonus items)

## Bonus

* You can use Patient Suit from 1st chapter all game long. Seems like it gives you infinite air.
* You can rehash modified in hex-editor save file to pass the in-game validation (recalculate MC02 and DS2-specific checksums). [^2]
* [Play as Weller](https://youtu.be/rySkJ4SgfFk).
* [Get Air Cans as in other games](https://youtu.be/72RzGN8867Y).

## Requirements

* .NET Framework 4.0 or Newer.

## Credits

* Thanks to [Adam Spindler](https://github.com/Experiment5X) for [EA's MC02 algorithm](https://gist.github.com/Experiment5X/5025310).

## Download

[Link](./download/DeadSpace2SaveEditor.exe?raw=true).

## Screenshots

<details>
<summary>Show</summary>

![Main](/Screenshots/Main.jpg)

![Items Editor](/Screenshots/ItemsEditor1.jpg)

![Items Editor](/Screenshots/ItemsEditor2.jpg)

![Items Editor](/Screenshots/ItemsEditor3.jpg)

</details>

### Footnotes

[^1]: but not tied to, so can be reordered. 
[^2]: as a side effect, some content is nullified (non-critical bug).
