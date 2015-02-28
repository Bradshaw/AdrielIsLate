using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

    public void restart()
    {
        if (this.gameObject.activeSelf)   
            Application.LoadLevel(0);
    }

}
