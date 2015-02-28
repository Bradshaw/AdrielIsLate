using UnityEngine;
using System.Collections;

public class GoodTipTapDisplay : MonoBehaviour {


    public Transform tipTarget;
    public Transform tapTarget;

    void Update()
    {
        tipTarget.localScale = Vector3.Lerp(tipTarget.localScale,Vector3.one,0.1f);
        tapTarget.localScale = Vector3.Lerp(tapTarget.localScale, Vector3.one, 0.1f);
    }


    public void goodTip()
    {
        tipTarget.localScale = Vector3.one * 0.5f;
    }

    public void goodTap()
    {
        tapTarget.localScale = Vector3.one * 0.5f;
    }

}
