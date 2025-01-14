using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCurveDemo : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0,1)] public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        t += Time.deltaTime;
        t %= 1;
        transform.localScale = Vector2.one * curve.Evaluate(t);
    }
}
