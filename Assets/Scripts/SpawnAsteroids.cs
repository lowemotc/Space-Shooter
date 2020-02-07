using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAsteroids : MonoBehaviour {
    public GameObject rockPrefab;
    public Transform player;
    Vector3 spawnPos;
    Quaternion spawnDir;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void callAsteroid()
    {
        List<GameObject> asteroids = new List<GameObject>();
        if(asteroids.Count < 7)
        {
            Instantiate<GameObject>(rockPrefab, spawnPos, spawnDir);
        }
    }

    void setAsteroidTransform()
    {
        float xRngLow = player.position.x - 6;
        float xRngHi = player.position.x + 6;
        float yRngLow = player.position.y - 6;
        float yRngHi = player.position.y + 6;

        spawnPos.Set(Random.Range(xRngLow, xRngHi), Random.Range(yRngLow, yRngHi), 0);

        spawnDir.Set(Random.Range(0, 360), Random.Range(0, 360), 0, spawnDir.w);
    }
}
