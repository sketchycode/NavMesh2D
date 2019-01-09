# NavMesh2D
A hacky way to get NavMesh AI navigation to work with the Tilemap 2D feature. The demo is a top-down view of a level I quickly built with Tilemap. Click anywhere to get the agent (rectangle) to move to that point.

First, this uses a rotated NavMesh to match the 2D world of the xy plane. I added a "ground" to the level, which is just a cube scaled up to be bigger than my tilemap level, and positioned it to match the depth (z) of my tilemap.

On start, a script does a 2D box overlap check against the tilemap for each tile coordinate. If a particular tile is a wall, generate a NavMesh Obstacle. Once we iterate through all tile locations, rebuild the navmesh. With a little bit of futzing we can position the sprite to match the agent gameobject every frame.

Concerning the syncing of agent to sprite, the agent rotates to face the direction it's going. You generally don't want to rotate the sprites about the z-axis. To solve this I just made the agent object and sprite object siblings of a common parent. The parent doesn't move, and the sprite object updates its position to the agent in LateUpdate.
