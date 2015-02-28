using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Restart : MonoBehaviour {

    void Update()
    {
        if (Input.anyKeyDown)
        {
            restart();
        }
    }

    public void restart()
    {
        if (this.gameObject.activeSelf)   
            Application.LoadLevel(0);
    }

}
