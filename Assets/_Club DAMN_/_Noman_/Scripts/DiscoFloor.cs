using UnityEngine;
using System.Collections;

public class DiscoFloor : MonoBehaviour
{
    public GameObject[] floorTiles; 
    public float changeInterval = 2.0f; 
    public float transitionDuration = 1.0f; 

    private void Start()
    {
        // Start the color changing routine for each floor tile with a random delay
        foreach (GameObject tile in floorTiles)
        {
            float delay = Random.Range(0f, changeInterval);
            StartCoroutine(StartTransitionAfterDelay(tile, delay));
        }
    }

    private IEnumerator StartTransitionAfterDelay(GameObject tile, float delay)
    {
        // Initial random delay before the first color change
        yield return new WaitForSeconds(delay);

        // After the initial delay, continuously change colors at intervals
        while (true)
        {
            // Start color transition coroutine
            StartCoroutine(TransitionColor(tile));

            // Wait for a random delay before starting the next color change
            float nextDelay = Random.Range(0f, changeInterval);
            yield return new WaitForSeconds(nextDelay);
        }
    }

    private IEnumerator TransitionColor(GameObject tile)
    {
        Renderer tileRenderer = tile.GetComponent<Renderer>();
        if (tileRenderer != null)
        {
            Color startColor = tileRenderer.material.color;
            Color targetColor = GetRandomColorOrBlack(); // Determine the target color

            // Transition to the target color over the transition duration
            for (float t = 0; t < 1; t += Time.deltaTime / transitionDuration)
            {
                Color newColor = Color.Lerp(startColor, targetColor, t);
                tileRenderer.material.color = newColor;
                tileRenderer.material.SetColor("_EmissionColor", newColor * Mathf.LinearToGammaSpace(2.0f));
                DynamicGI.SetEmissive(tileRenderer, newColor);
                yield return null;
            }

            // Ensure the final color is set to the target color
            tileRenderer.material.color = targetColor;
            tileRenderer.material.SetColor("_EmissionColor", targetColor * Mathf.LinearToGammaSpace(2.0f));
            DynamicGI.SetEmissive(tileRenderer, targetColor);
        }
    }

    private Color GetRandomColorOrBlack()
    {
        // Chance of the tile turning off (black)
        float chanceOfBlack = 0.6f; // 10% chance for a tile to turn black

        if (Random.value < chanceOfBlack)
        {
            return Color.black;
        }
        else
        {
            // Generate a random neon color
            float hueMin = 0f;
            float hueMax = 1f;
            float saturationMin = 0.5f;
            float valueMin = 0.5f;
            Color emissionColor = Random.ColorHSV(hueMin, hueMax, saturationMin, 1f, valueMin, 1f);
            return emissionColor * Mathf.LinearToGammaSpace(30.0f); // Apply gamma space conversion for brighter emission
        }
    }
}