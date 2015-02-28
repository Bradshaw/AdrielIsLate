using UnityEngine;
using System.Collections;

public class SparkWhenFast : MonoBehaviour {

    public TipTapSpeeder adriel;
    public GameObject Spark;

    public float minTimeBetweenSparks;
    public float maxTimeBetweenSparks;

    float nextSparkAt = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (adriel.speed >= 5)
        {
            if (Time.time > nextSparkAt)
            {
                GameObject go = Instantiate(Spark) as GameObject;
                go.transform.position = transform.position;
                nextSparkAt = Time.time + Random.Range(minTimeBetweenSparks, maxTimeBetweenSparks);
            }
        }
	}
}
