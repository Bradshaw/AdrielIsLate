using UnityEngine;
using System.Collections;

public class SpinSpinSpin : MonoBehaviour {

    public float speed;

	// Update is called once per frame
	void Update () {
        transform.localRotation = Quaternion.Euler(0, 0, Time.time * speed * 360);
	}
}
