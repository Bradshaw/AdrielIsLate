using UnityEngine;
using System.Collections;

public enum TipTapPhase
{
    TIP,
    TAP
}

public class TipTapSpeeder : MonoBehaviour {

    public float minumumSpeed;
    public float maximumSpeed;
    public float drag;
    public float minimumTapFreq;
    public float maximumTapFreq;

    
    public UnityEngine.UI.Text uitext;

    float _speed;
    public float speed
    {
        get { return _speed; }
        set { _speed = Mathf.Clamp(value, minumumSpeed, maximumSpeed); }
    }

    float phase = 0;
    TipTapPhase prev_phase;
    public TipTapPhase current_phase {
        get
        {
            var next_phase = (Mathf.FloorToInt(phase) % 2 == 0 ? TipTapPhase.TIP : TipTapPhase.TAP);
            if (next_phase != prev_phase)
                switchPhase(next_phase);

            prev_phase = next_phase;

            return next_phase;
        }
        set { phase = (phase - Mathf.FloorToInt(phase)) + (value.isTip() ? 0 : 1); }
    }
    bool tipped = false;
    bool tapped = false;


	// Use this for initialization
	void Start () {
        speed = minumumSpeed;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float tapSpeed = ((speed - minumumSpeed) / (maximumSpeed - minumumSpeed)) * (maximumTapFreq - minimumTapFreq) + minimumTapFreq;
        phase += Time.fixedDeltaTime * tapSpeed;
        if (phase > 2) phase -= 2;

        if (uitext!=null)
            uitext.text = speed+" "+current_phase.toString();

        speed = speed - speed * drag * Time.fixedDeltaTime;
	}

    public void doTip()
    {
        if (!tipped)
        {
            if (current_phase.isTip())
                speed++;
            else
                speed--;
        }
        tipped = true;
    }
    public void doTap()
    {
        if (!tapped)
        {
            if (current_phase.isTap())
                speed++;
            else
                speed--;
        }
        tapped = true;
    }

    void switchPhase(TipTapPhase new_phase)
    {
        tipped = false;
        tapped = false;
    }

    

}

public static class TipTapPhaseExtension
{
    public static bool isTip(this TipTapPhase ttp)
    {
        return ttp == TipTapPhase.TIP;
    }
    public static bool isTap(this TipTapPhase ttp)
    {
        return ttp == TipTapPhase.TAP;
    }
    public static string toString(this TipTapPhase ttp)
    {
        return (ttp.isTip() ? "Tip" : "Tap");
    }
}
