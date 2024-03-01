**Gustaf Larsson
Malmö Universitet**

This is a project in Unity, using different procedural conctent generation methods to create digital terrain.

I implemented my own version of **Perlin Noise** that uses a seed to create psuedo random height values that is used to raise or lower the ground of the terrain. The result is moutains and vallewy or a moon like surface.

I implemented **agent-based PCG** with three agents interact with the terrain, shaping it in a psuedo-random but structured way. 
The first agents is a moutain-agent that raises moutains. 
The second agent is a river-agent, that crates a branching river that crosses the terrain.
The last agent is a smoothing-agent which crosses the whole map and smooths the terrain to look more natural.
