using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Tween 
{
    public static void Move(GameObject _targetObject, Vector3 _targetPosition, float _totalDuration, Action _onComplete = null)
    {
        var objectToMove = !_targetObject.GetComponent<TweenMove>()
            ? _targetObject.AddComponent<TweenMove>()
            : _targetObject.GetComponent<TweenMove>();

        objectToMove.elapsedDuration = 0;
        objectToMove.targetPosition = _targetPosition;
        objectToMove.totalDuration = _totalDuration;
        objectToMove.startPosition = _targetObject.transform.position;
        objectToMove.onComplete = _onComplete;
        objectToMove.enabled = true;
    }

    public static void Fade(Image _targetImage, float _targetAlpha, float _totalDuration, Action _onComplete = null)
    {
        var objectToFade = !_targetImage.gameObject.GetComponent<TweenFade>()
            ? _targetImage.gameObject.AddComponent<TweenFade>()
            : _targetImage.gameObject.GetComponent<TweenFade>();

        objectToFade.elapsedDuration = 0;
        objectToFade.targetImage = _targetImage;
        objectToFade.targetAlpha = _targetAlpha;
        objectToFade.startAlpha = _targetImage.color.a;
        objectToFade.totalDuration = _totalDuration;
        objectToFade.onComplete = _onComplete;
        objectToFade.enabled = true;
    }
}
