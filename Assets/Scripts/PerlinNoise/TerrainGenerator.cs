using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    [SerializeField] private int depth = 25;
    private int width = 256;
    private int height = 256;

    [SerializeField] float scale;

    [SerializeField] bool myPerlinNoiseVersion;
    [SerializeField] bool continuesUpdate;

    [SerializeField] float seed;

    Terrain terrain;

    PerlinNoise perlin;

    private void Start()
    {
        perlin = GetComponent<PerlinNoise>();
        terrain = GetComponent<Terrain>();

        seed = -5;

        UpdateTerrainData();
    }

    private void Update()
    {
        if(continuesUpdate) UpdateTerrainData();
    }

    private void UpdateTerrainData()
    {
        terrain.terrainData = GenrerateTerrain(terrain.terrainData);
    }

    private TerrainData GenrerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = height + 1;
        terrainData.size = new Vector3(width, depth, height);

        terrainData.SetHeights(0, 0, GenreateHeigths());

        return terrainData;
    }

    private float[,] GenreateHeigths()
    {
        float[,] heigths = new float[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                heigths[x, y] = CalculateHeight(x, y);
            }
        }
        return heigths;
    }

    private float CalculateHeight(int x, int y)
    {
        float xCoord = (float)x / width * (scale * -1) + seed;
        float yCoord = (float)y / height * (scale * -1) + seed;

        if (myPerlinNoiseVersion) return perlin.GenerateNoise(xCoord, yCoord);

        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
