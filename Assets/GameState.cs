using UnityEngine;
using System.Collections;
using System.Collections.Generic;


[RequireComponent(typeof(TheTrainJamTrain))]
public class GameState : MonoBehaviour {

    public TipTapSpeeder adriel;
    public List<GameObject> turnTheseOffAtGameOver;
    public List<GameObject> turnTheseOnAtGameOver;
    public List<GameObject> turnTheseOffAtGameStart;
    public List<GameObject> turnTheseOnAtGameStart;
    public float restartTime = 10;

    bool gameon = true;
    float restartAt = 0;

	// Use this for initialization
	void Start () {
        gameon = true;
        GameStart();
	}
	
	// Update is called once per frame
	void Update () {
        if (gameon)
        {
            if (GetComponent<TheTrainJamTrain>().current_position < 0)
            {
                gameon = false;
                restartAt = Time.time + restartTime;
                GameOver();
            }
        }
        else
        {
            if (Time.time > restartAt)
            {
                var train = GetComponent<TheTrainJamTrain>();
                train.current_position = 5;
                train.current_speed = 1;
                gameon = true;
                GameStart();
            }
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
    public void GameStart()
    {
        adriel.speed = 0;
        foreach (GameObject go in turnTheseOffAtGameStart)
        {
            go.SetActive(false);
        }
        foreach (GameObject go in turnTheseOnAtGameStart)
        {
            go.SetActive(true);
        }
    }

}
