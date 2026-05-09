using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject[] randomObjects; // Array of objects to spawn
    public Transform[] ramdomPoints; // Array of points where objects can be spawned
    public float spawnInterval; // Time interval between spawns
    public float time;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        time -= Time.deltaTime; // Decrease the timer by the time elapsed since the last frame
        if (time <= 0) // Check if the timer has reached zero
        {
            int randomIndex = Random.Range(0, randomObjects.Length); // Get a random index for the object to spawn
            int randomPointIndex = Random.Range(0, ramdomPoints.Length); // Get a random index for the spawn point
            Instantiate(randomObjects[randomIndex], ramdomPoints[randomPointIndex].position, Quaternion.identity);
            time = spawnInterval; // Reset the timer to the spawn interval
        }
    }
}
