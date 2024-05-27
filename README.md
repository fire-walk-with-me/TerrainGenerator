**Gustaf Larsson
Malmö Universitet**

This is a project in Unity, using different procedural content generation(PCG) methods to create digital terrain.

I implemented my own version of **Perlin Noise** that uses a seed to create psuedo random height values that is used to raise or lower the ground of the terrain. The result is terrain that looks like moutains and valleys or a moon like surface.

<img width="410" alt="Screenshot 2024-05-07 at 09 32 29" src="https://github.com/fire-walk-with-me/TerrainGenerator/assets/78409816/1998eb40-da4c-411a-9be8-f1871a4dd722">

<br>
<br>
I also implemented **agent-based PCG** with three agents interact with the terrain, shaping it in a psuedo-random but structured way. 
The first agents is a **moutain-agent** that raises moutains. 
The second agent is a **river-agent**, that crates a branching river that crosses the terrain.
The last agent is a **smoothing-agent** which crosses the whole map and smooths the terrain to look more natural.
<img width="692" alt="Screenshot 2024-05-07 at 09 33 13" src="https://github.com/fire-walk-with-me/TerrainGenerator/assets/78409816/1296125e-6d05-4858-8270-6eec9c0b7ea8">
<img width="689" alt="Screenshot 2024-05-07 at 09 33 29" src="https://github.com/fire-walk-with-me/TerrainGenerator/assets/78409816/aa62b012-4d5d-4be9-ad5b-35edfa344c49">
<img width="692" alt="Screenshot 2024-05-07 at 09 34 02" src="https://github.com/fire-walk-with-me/TerrainGenerator/assets/78409816/85a9089a-b604-455e-86d8-90524877918d">
<img width="691" alt="Screenshot 2024-05-07 at 09 34 18" src="https://github.com/fire-walk-with-me/TerrainGenerator/assets/78409816/07de0fe8-88f4-48e2-a386-6cb9780f1825">
<img width="691" alt="Screenshot 2024-05-07 at 09 33 41" src="https://github.com/fire-walk-with-me/TerrainGenerator/assets/78409816/cfebcd95-3439-4f46-ad13-6330fff0cc1d">
