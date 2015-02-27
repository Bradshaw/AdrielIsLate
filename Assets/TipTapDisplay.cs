using UnityEngine;
using System.Collections;

[RequireComponent(typeof(TipTapSpeeder))]
public class TipTapDisplay : MonoBehaviour {

	public Color tip;
    public Color tap;
	
	// Update is called once per frame
	void Update () {
        renderer.material.color = (GetComponent<TipTapSpeeder>().current_phase.isTip() ? tip : tap);
        transform.position = Vector3.left * (GetComponent<TipTapSpeeder>().current_phase.isTip() ? 2 : -2);
	}
}
