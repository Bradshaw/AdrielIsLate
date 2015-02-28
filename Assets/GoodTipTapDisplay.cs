using UnityEngine;
using System.Collections;

public class GoodTipTapDisplay : MonoBehaviour {

    public GameObject sparkle;
    public int sparkleCount;

    public Transform tipTarget;
    public Transform tapTarget;

    public AudioSource tipSound;
    public AudioSource tapSound;

    void Update()
    {
        tipTarget.localScale = Vector3.Lerp(tipTarget.localScale,Vector3.one,0.1f);
        tapTarget.localScale = Vector3.Lerp(tapTarget.localScale, Vector3.one, 0.1f);
    }


    public void goodTip()
    {
        tipTarget.localScale = Vector3.one * 0.5f;
        for (int i = 0; i<sparkleCount; i++)
        {
            GameObject go = Instantiate(sparkle) as GameObject;
            go.transform.position = tipTarget.position;
        }
        tipSound.Play();
    }

    public void goodTap()
    {
        tapTarget.localScale = Vector3.one * 0.5f;
        for (int i = 0; i < sparkleCount; i++)
        {
            GameObject go = Instantiate(sparkle) as GameObject;
            go.transform.position = tapTarget.position;
        }
        tapSound.Play();
    }

}
