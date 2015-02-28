using UnityEngine;
using System.Collections;

public class WaveyWavey : MonoBehaviour {

    public float amplitude;
    public float minFreq;
    public float maxFreq;

    float freq;
    float offset;

	// Use this for initialization
	void Start () {
        freq = Random.Range(minFreq, maxFreq);
        offset = Random.Range(0, Mathf.PI * 2);
	}
	
	// Update is called once per frame
	void Update () {
        transform.localRotation = Quaternion.Euler(
            0,
            0,
            Mathf.Sin(Time.time * freq * Mathf.PI + offset) * amplitude
        );
	}
}
