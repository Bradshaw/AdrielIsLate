using UnityEngine;
using System.Collections;

public class DeleteAtRange : MonoBehaviour {

    public float deleteAt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.magnitude > deleteAt)
            Destroy(this.gameObject);
	}
}
