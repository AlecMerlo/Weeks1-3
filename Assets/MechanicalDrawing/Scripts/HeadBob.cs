using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBob : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    public AnimationCurve curve;
    float t;

    // Update is called once per frame
    void Update()
    {
        // moving up and down with lerp
        t += Time.deltaTime / 5;
        t %= 1;
        transform.position = Vector3.Lerp(startPos.position, endPos.position, curve.Evaluate(t));
    }
}
