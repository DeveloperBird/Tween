using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenMove : TweenData
{
    public Vector3 targetPosition;
    public Vector3 startPosition;

    public override void Update()
    {
        base.Update();

        float percent = elapsedDuration / totalDuration;

        transform.position = Vector3.Lerp(startPosition, targetPosition, percent);

    }
}
