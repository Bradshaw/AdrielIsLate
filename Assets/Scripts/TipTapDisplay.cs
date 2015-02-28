using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TipTapSpeeder))]
public class TipTapDisplay : MonoBehaviour {

    public GameObject arrow;
    public float wobangle;

	public GameObject tip;
    public GameObject tap;

    public GameObject tipArms;
    public GameObject tapArms;
	
	// Update is called once per frame
	void Update () {
        TipTapPhase ph = GetComponent<TipTapSpeeder>().current_phase;
        float pha = GetComponent<TipTapSpeeder>().phase+0.25f;
        //tip.GetComponent<SpriteRenderer>().enabled = ph.isTip();
        //tap.GetComponent<SpriteRenderer>().enabled = ph.isTap();
        tipArms.SetActive(ph.isTip());
        tapArms.SetActive(ph.isTap());

        arrow.transform.rotation = Quaternion.Euler(0,0,(Mathf.Sin((pha*Mathf.PI)/2)*wobangle));

	}
}
