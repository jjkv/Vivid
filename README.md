jjkv: i'm 'jack', new account :D

11/18/16 jack update:
scripts and an explanation can be found in my update. i implemented the
game manager, fixed some physics bugs, cleaned up lens enabling, updated
ui transitions, and created tutorials (exported as an asset package, can be 
found on dropbox).

﻿Vivid
11/14/2016
Aden, Charles, Jack, Chris, Xu, Mike

This repository holds the scripts used in our video game, VIVID.

As of 11/14/16, the three scripts most important to keep track of are:

	color_change:
		 applied to the character controller, changes the color of light and objects 
		 and calls on_update
	Update_plats:
		also applied to the character controller, changes the physics of 
		platform type objects based on their color.
		NOTE: plats must be cubes with rigidbodies
	Update_intrs:
		also applied to the character controller, changes the physics of 
		'interactable' type objects based on their color. 
		NOTE: intrs must be cylinders or capsules with rigidbodies

Upcoming changes: 

	Implement a gamemangager to set up levels and transition between scenes

	Implement the UI

	Implement deaths and level transitions

To Consider:

	Expand this repository to include prefabs, materials, and art/textures
	
	New Object Type with simple AI behavior?
	
	Ability to pick up and put down certain objects?
