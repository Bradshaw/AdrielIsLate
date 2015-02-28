using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TiledBackground : MonoBehaviour {

    public GameObject tilePrefab;
    public float tileWidth;
    public float scrollSpeed;
    public float coverwidth;

    Queue<GameObject> tiles;

	// Use this for initialization
	void Start () {
        tiles = new Queue<GameObject>();
        for (float pos = coverwidth * 2 + tileWidth; pos > -coverwidth * 2 - tileWidth; pos -= tileWidth)
        {
            GameObject t = Instantiate(tilePrefab) as GameObject;
            t.transform.position = Vector3.right * pos;
            tiles.Enqueue(t);
        }
	}

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject t in tiles)
        {
            t.transform.position = t.transform.position + Vector3.right * scrollSpeed * Time.deltaTime;
        }
        if (tiles.Peek().transform.position.magnitude > coverwidth * 2 + tileWidth)
        {
            GameObject go = tiles.Dequeue();
            go.transform.position = go.transform.position + Vector3.left * (coverwidth * 4 + tileWidth * 2);
            tiles.Enqueue(go);
        }
	}
}
