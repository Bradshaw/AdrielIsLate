using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpawnThings : MonoBehaviour {

    public GameObject thing;
    public List<Sprite> thingSprites;

    public float minTime;
    public float maxTime;

    public float verticalSpread;
    float lastSpawned;
    float waitFor;

	// Use this for initialization
	void Start () {
        lastSpawned = Time.time;
        waitFor = Random.Range(minTime, maxTime);
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.time > lastSpawned + waitFor)
        {
            GameObject go = Instantiate(thing) as GameObject;
            go.transform.position = this.transform.position + Vector3.up * Random.Range(-verticalSpread, verticalSpread);
            go.GetComponentInChildren<SpriteRenderer>().sprite = thingSprites[Random.Range(0, thingSprites.Count - 1)];

            lastSpawned = Time.time;
            waitFor = Random.Range(minTime, maxTime);
        }
	}
}
