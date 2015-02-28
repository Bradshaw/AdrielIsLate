using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(TipTapSpeeder))]
public class HalfKeyboardTipTap : MonoBehaviour {

    public List<string> tipButtons;
    public List<string> tapButtons;

	// Update is called once per frame
	void Update () {
        if (UnityInputSucks.GetKeyDown(tipButtons))
            GetComponent<TipTapSpeeder>().doTip();

        if (UnityInputSucks.GetKeyDown(tapButtons))
            GetComponent<TipTapSpeeder>().doTap();
	}


}

public static class UnityInputSucks
{
    public static bool GetKeyDown(List<string> buttons)
    {
        foreach (string button in buttons)
        {
            if (Input.GetKeyDown(button))
                return true;
        }
        return false;
    }
}
