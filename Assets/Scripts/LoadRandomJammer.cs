using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(SpriteRenderer))]
public class LoadRandomJammer : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = JammerPool.getJammer();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

