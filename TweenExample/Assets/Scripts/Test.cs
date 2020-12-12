using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public GameObject circleObject;
    public Transform endPosition;

    // Start is called before the first frame update
    void Start()
    {
        Tween.Move(circleObject, endPosition.position, 2.5f, 
            () => Tween.Fade(circleObject.GetComponent<Image>(), 0, 2.5f));
    }
}
