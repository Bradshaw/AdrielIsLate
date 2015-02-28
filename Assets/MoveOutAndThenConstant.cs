using UnityEngine;
using System.Collections;

public class MoveOutAndThenConstant : MonoBehaviour {

    public float maxInitialSpeed;
    public float minInitialSpeed;
    public float minAngle;
    public float maxAngle;
    public Vector3 constantSpeed;
    public float timeToConstant;

    Vector3 currentVel;
    Vector3 dampVel;

	// Use this for initialization
	void Start () {
        dampVel = Vector3.zero;
        var initialSpeed = Random.Range(minInitialSpeed,maxInitialSpeed);
        var initialAngle = Random.Range(minAngle, maxAngle);
        currentVel = new Vector3(
            Mathf.Cos(initialAngle) * initialSpeed,
            Mathf.Sin(initialAngle) * initialSpeed,
            0
        );

	}
	
	// Update is called once per frame
	void Update () {
        currentVel = Vector3.SmoothDamp(currentVel, constantSpeed, ref dampVel, timeToConstant);
        transform.position += currentVel * Time.deltaTime;
	}
}
