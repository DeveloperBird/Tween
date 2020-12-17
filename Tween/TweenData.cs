using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenData : MonoBehaviour
{
    public float elapsedDuration;
    public float totalDuration;
    public Action onComplete;

    public virtual void Update()
    {
        elapsedDuration += Time.deltaTime; //tracks the elasped time

        if(elapsedDuration >= totalDuration) //this should be the end of the animation
        {
            enabled = false;
            onComplete?.Invoke();
        }
    }
}
