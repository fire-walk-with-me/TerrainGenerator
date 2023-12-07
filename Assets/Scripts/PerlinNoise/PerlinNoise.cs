using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    [SerializeField] bool wrongKindOfRandom = false;
    public float GenerateNoise(float x, float y)
    {
        //grid cell coordinates
        int x0 = Mathf.FloorToInt(x);
        int x1 = x0 + 1;
        int y0 = Mathf.FloorToInt(y);
        int y1 = y0 + 1;

        float sx = x - x0;
        float sy = y - y0;

        float n0, n1, ix0, ix1, value;

        n0 = DotGridGradient(x0, y0, x, y);
        n1 = DotGridGradient(x1, y0, x, y);
        ix0 = Interpolate(n0, n1, sx);

        n0 = DotGridGradient(x0, y1, x, y);
        n1 = DotGridGradient(x1, y1, x, y);
        ix1 = Interpolate(n0, n1, sx);

        value = Interpolate(ix0, ix1, sy);

        return value;
    }

    private float Interpolate(float a0, float a1, float weight)
    {
        if (0.0 > weight) return a0;
        if (1.0 < weight) return a1;

        //return (a1 - a0) * weight + a0;
        //return (a1 - a0) * (3.0f - weight * 2.0f) * weight * weight + a0;
        return (a1 - a0) * ((weight * (weight * 6.0f - 15.0f) + 10.0f) * weight * weight * weight) + a0;
    }

    Vector2 RandomGradient(int ix, int iy)
    {
        Vector2 v;

        float a = ix, b = iy;

        a *= 3284157443f;
        b += Mathf.Pow(b, a);

        b *= 1911520717f;
        a += Mathf.Pow(a, b);

        a *= 2048419325f;

        float random = a * (Mathf.PI / b);

        if (wrongKindOfRandom)
        {
            v.x = Random.value;
            v.y = Random.value;

            return v;
        }

        v.x = Mathf.Cos(random); v.y = Mathf.Sin(random);

        return v;
    }

    private float DotGridGradient(int ix, int iy, float x, float y)
    {
        Vector2 gradient = RandomGradient(ix, iy);

        float dx = x - ix;
        float dy = y - iy;

        return (dx * gradient.x + dy * gradient.y);
    }
}
