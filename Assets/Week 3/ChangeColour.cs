using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public GameObject shape;
    SpriteRenderer squareSpriteRenderer;
    Color squareColor;

    // Start is called before the first frame update
    void Start()
    {
        squareSpriteRenderer = GetComponent<SpriteRenderer>();
        squareSpriteRenderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        squareSpriteRenderer.color = Color.red;
    }

    void OnMouseExit()
    {
        squareSpriteRenderer.color = Color.white;
    }
}
