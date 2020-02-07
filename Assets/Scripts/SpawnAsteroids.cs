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
        spawnDir.eulerAngles.Set(Random.value * 360, Random.value * 360, 0);
    }
}
