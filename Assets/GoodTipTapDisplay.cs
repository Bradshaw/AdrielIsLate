using UnityEngine;
using System.Collections;

public class GoodTipTapDisplay : MonoBehaviour {

    public int count;

    public GameObject onTip;
    public GameObject onTap;

    public Transform tipTarget;
    public Transform tapTarget;

    public void goodTip()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject go = Instantiate(onTip) as GameObject;
            go.transform.position = tipTarget.transform.position;
        }
    }

    public void goodTap()
    {
        for (int i = 0; i < count; i++)
        {
            GameObject go = Instantiate(onTap) as GameObject;
            go.transform.position = tapTarget.transform.position;
        }
    }

}
