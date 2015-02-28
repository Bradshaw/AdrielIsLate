using UnityEngine;
using System.Collections;

public class BadTipTapDisplay : MonoBehaviour {

    public GameObject tip;
    public GameObject tap;

    public Sprite badSprite;

    Sprite tipSprite;
    Sprite tapSprite;

    Transform tipTarget;
    Transform tapTarget;

    public AudioSource badTipTapSound;

    void Start()
    {
        tipSprite = tip.GetComponent<SpriteRenderer>().sprite;
        tapSprite = tap.GetComponent<SpriteRenderer>().sprite;

        tipTarget = tip.transform;
        tapTarget = tap.transform;
    }

    void Update()
    {
        tipTarget.localScale = Vector3.Lerp(tipTarget.localScale, Vector3.one, 0.1f);
        tapTarget.localScale = Vector3.Lerp(tapTarget.localScale, Vector3.one, 0.1f);

        if (tipTarget.localScale.sqrMagnitude < (Vector3.one * 1.01f).sqrMagnitude)
            tip.GetComponent<SpriteRenderer>().sprite = tipSprite;

        if (tapTarget.localScale.sqrMagnitude < (Vector3.one * 1.01f).sqrMagnitude)
            tap.GetComponent<SpriteRenderer>().sprite = tapSprite;
    }


    public void badTip()
    {
        tipTarget.localScale = Vector3.one * 1.5f;
        tip.GetComponent<SpriteRenderer>().sprite = badSprite;
        badTipTapSound.Play();
    }

    public void badTap()
    {
        tapTarget.localScale = Vector3.one * 1.5f;
        tap.GetComponent<SpriteRenderer>().sprite = badSprite;
        badTipTapSound.Play();
    }
}
