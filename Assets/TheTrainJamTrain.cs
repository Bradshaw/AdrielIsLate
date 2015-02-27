using UnityEngine;
using System.Collections;

public class TheTrainJamTrain : MonoBehaviour {

    public TipTapSpeeder TipTapSpeederThingThatIsBasicallyTheWholeGame;

    public float startSpeed;
    public float startPosition;
    public float maxSpeed;
    public float maxPosition;
    public float acceleration;
    public Vector3 positionScaling;
    
    float _current_speed;
    public float current_speed
    {
        get { return _current_speed; }
        set { _current_speed = Mathf.Clamp(value, 0, maxSpeed); }
    }
    [HideInInspector]
    public float current_position;


	// Use this for initialization
	void Start () {
        current_speed = startSpeed;
        current_position = startPosition;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        current_position += current_speed * Time.fixedDeltaTime - TipTapSpeederThingThatIsBasicallyTheWholeGame.speed * Time.fixedDeltaTime;
        if (current_position > maxPosition)
            current_speed -= acceleration * Time.fixedDeltaTime;
        else
            current_speed += acceleration * Time.fixedDeltaTime;
        transform.position = positionScaling * current_position;

	}
}
