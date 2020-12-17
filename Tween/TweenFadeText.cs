using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TweenFadeText : TweenData {

    public Text targetText;
    public float targetAlpha;
    public float startAlpha;

    public override void Update()
    {
        base.Update();

        var percent = elapsedDuration / totalDuration;

        var TC = targetText.color;
        targetText.color = new Color(TC.r, TC.g, TC.b,
            Mathf.Lerp(startAlpha, targetAlpha, percent));
    }
}
