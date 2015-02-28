using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class JammerPool : MonoBehaviour {

    static JammerPool _instance;
    public static JammerPool instance
    {
        get
        {
            return _instance;
        }
    }

    public List<Sprite> jammers;

    public static Sprite getJammer()
    {
        int index = Random.Range(0, instance.jammers.Count);
        Sprite spr = instance.jammers[index];
        instance.jammers.RemoveAt(index);
        return spr;
    }

	// Use this for initialization
	void Awake () {
        if (_instance == null)
            _instance = this;
        else
            Destroy(this.gameObject);
	}
	
}
