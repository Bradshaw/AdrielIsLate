using UnityEngine;
using System.Collections;

public class SpawnAhead : MonoBehaviour {

    public float removeAtDistance;
    public Vector3 spawnPoint;

	// Use this for initialization
	void Start () {
        if (spawnPoint.magnitude > removeAtDistance)
            Debug.LogWarning("Spawn distance is too far from center");
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.magnitude > removeAtDistance)
            transform.position = spawnPoint;
	}
}
