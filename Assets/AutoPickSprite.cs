using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AutoPickSprite : MonoBehaviour {

    public List<Sprite> pickfrom;

	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().sprite = pickfrom[Random.Range(0, pickfrom.Count)];
	}
}
