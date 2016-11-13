Vivid
11/13/2016
Aden, Charles, Jack, Chris, Xu, Mike

This repository holds the scripts used in our video game, VIVID.

As of 11/12/16, the two scripts most important to keep track of are:
	color_change:
		 applied to the character controller, changes the color of light and objects 
		 and calls on_update
	on_update:
		also applied to the character controller, changes the physics of objects
		based on their color.

Upcoming changes: 
	rename on_update to update_platforms, create new script called update_interacts
	for objects to be affected by gravity, and physics.

	Implement a gamemangager to set up levels and transition between scenes

	Implement the UI

	Implement deaths and level transitions

To Consider:
	Expand this repository to include prefabs, materials, and art/textures
