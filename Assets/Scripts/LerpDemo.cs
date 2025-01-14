using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{
    [Range(0, 1)] public float t;

    public AnimationCurve curve;
    public Transform start;
    public Transform end;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        t %= 1;
        transform.position = Vector2.one * Vector2.Lerp(start.position, end.position, curve.Evaluate(t));
    }
}
