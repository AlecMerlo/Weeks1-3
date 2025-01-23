using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public AnimationCurve curve;
    public float y;
    float t;
    public Vector3 basePos;
    // Update is called once per frame
    void Update()
    {
        t += (Time.deltaTime * 0.8f);
        t %= 1;
        transform.localPosition = basePos - (Vector3.up * curve.Evaluate(t) * 12);
    }
}
