using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[RequireComponent(typeof(TheTrainJamTrain))]
public class GameState : MonoBehaviour {


    public TipTapSpeeder adriel;
    public GameObject startPrompt;
    public List<GameObject> turnTheseOffAtGameOver;
    public List<GameObject> turnTheseOnAtGameOver;
    public float restartTime = 1;

    bool gameon = true;
    float promptAt = 0;

	// Use this for initialization
	void Start () {
        gameon = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (gameon)
        {
            if (GetComponent<TheTrainJamTrain>().current_position < 0)
            {
                gameon = false;
                startPrompt.SetActive(false);
                promptAt = Time.time + restartTime;
                GetComponent<AudioSource>().Play();
                GameOver();
            }
        }
        else
        {
            if (Time.time > promptAt)
                startPrompt.SetActive(true);
        }
	}

    public void GameOver()
    {
        foreach (GameObject go in turnTheseOffAtGameOver)
        {
            go.SetActive(false);
        }
        foreach (GameObject go in turnTheseOnAtGameOver)
        {
            go.SetActive(true);
        }
    }

}
