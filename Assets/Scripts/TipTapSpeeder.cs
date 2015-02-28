using UnityEngine;
using System.Collections;

public enum TipTapPhase
{
    TIP = 0,
    TIPTAP,
    TAP,
    TAPTIP,
}

public class TipTapSpeeder : MonoBehaviour {

    public float minumumSpeed;
    public float maximumSpeed;
    public float drag;
    public float minimumTapFreq;
    public float maximumTapFreq;


    float _speed;
    public float speed
    {
        get { return _speed; }
        set { _speed = Mathf.Clamp(value, minumumSpeed, maximumSpeed); }
    }

    public float phase = 0;
    TipTapPhase prev_phase;
    public TipTapPhase current_phase {
        get
        {
            TipTapPhase next_phase = (TipTapPhase) (Mathf.FloorToInt(phase) % 4);
            if (next_phase.isTip() != prev_phase.isTip())
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
        phase += Time.fixedDeltaTime * tapSpeed * 2;
        if (phase > 4) phase -= 4;

        speed = speed - speed * drag * Time.fixedDeltaTime;
	}

    public void doTip()
    {
        if (!tipped)
        {
            if (current_phase.isTip())
            {
                speed++;
                GetComponent<GoodTipTapDisplay>().goodTip();
            }
            else
            {
                speed--;
                GetComponent<BadTipTapDisplay>().badTip();
            }
        }
        tipped = true;
    }
    public void doTap()
    {
        if (!tapped)
        {
            if (current_phase.isTap())
            {
                speed++;
                GetComponent<GoodTipTapDisplay>().goodTap();
            }
            else
            {
                speed--;
                GetComponent<BadTipTapDisplay>().badTap();
            }
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
        return ttp == TipTapPhase.TIP || ttp == TipTapPhase.TIPTAP;
    }
    public static bool isTap(this TipTapPhase ttp)
    {
        return ttp == TipTapPhase.TAP || ttp == TipTapPhase.TAPTIP;
    }
    public static bool canTip(this TipTapPhase ttp)
    {
        return ttp != TipTapPhase.TAP;
    }
    public static bool canTap(this TipTapPhase ttp)
    {
        return ttp != TipTapPhase.TIP;
    }
    public static string toString(this TipTapPhase ttp)
    {
        return (ttp.isTip() ? "Tip" : "Tap");
    }
}
