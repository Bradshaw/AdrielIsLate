using UnityEngine;
using System.Collections;

public class TapDetector : MonoBehaviour {

    public TipTapSpeeder tts;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var ts = Input.touches;
        foreach (Touch t in ts)
        {
            if (t.phase == TouchPhase.Began)
            {
                if (t.position.x > Screen.width / 2)
                {
                    tts.doTap();
                }
                else
                {
                    tts.doTip();
                }

            }
        }

	}
}
