using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BurstParticles : MonoBehaviour {

    public Transform SpawnAround;
    public GameObject prefab;
    public List<Sprite> sprites;
    public int count;
    public float randDist;

    public void burst()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject go = Instantiate(prefab) as GameObject;
            
            go.GetComponentInChildren<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Count - 1)];
            go.transform.position = SpawnAround.position + Random.insideUnitSphere;


        }

    }
}
