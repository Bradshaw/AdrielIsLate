using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TipTapSpeeder))]
public class TipTapDisplay : MonoBehaviour {

	public GameObject tip;
    public GameObject tap;

    public GameObject tipArms;
    public GameObject tapArms;
	
	// Update is called once per frame
	void Update () {
        bool tippy = GetComponent<TipTapSpeeder>().current_phase.isTip();
        bool tappy = GetComponent<TipTapSpeeder>().current_phase.isTap();
        tip.GetComponent<SpriteRenderer>().enabled = tippy;
        tap.GetComponent<SpriteRenderer>().enabled = tappy;
        tipArms.SetActive(tippy);
        tapArms.SetActive(tappy);
	}
}
