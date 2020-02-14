using UnityEngine;

public class Asteroid_Spawning : MonoBehaviour {
    public GameObject rockPrefab;
    public Transform player;
    Vector3 spawnPos;
    Quaternion spawnDir;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (player != null)
        {
            SetAsteroidTransform(player.position.x, player.position.y);
            CallAsteroid();
        }
	}

    void CallAsteroid()
    {
        GameObject[] tRockArray = GameObject.FindGameObjectsWithTag("Asteroid");
        int rocks = 0;
        foreach (GameObject tRock in tRockArray)
        {
            rocks++;
        }
        if (rocks < 7)
        {
            Instantiate<GameObject>(rockPrefab, spawnPos, spawnDir);
        }
        else
        {
            return;
        }
    }

    void SetAsteroidTransform(float x, float y)
    {
        float xRngLow = x - 10;
        float xRngHi = x + 10;
        float yRngLow = y - 10;
        float yRngHi = y + 10;

        spawnPos.Set(Random.Range(Random.Range(-49, xRngLow), Random.Range(xRngHi, 49)), Random.Range(Random.Range(-49, yRngLow), Random.Range(yRngHi, 49)), 0);
        spawnDir.Set(Random.Range(0, 360), Random.Range(0, 360), 0, spawnDir.w);
    }
}
