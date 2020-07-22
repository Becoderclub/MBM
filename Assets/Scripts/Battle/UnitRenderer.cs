using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SpriteRenderer))]
public class UnitRenderer : MonoBehaviour
{
    // no text yet, idk how to create text objects in runtime,
    // and attaching one to a prefab doesn't seem to work
    // also idk how to make healthbars

    //private Text text;
    private SpriteRenderer sRenderer;
    public Unit unit;

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();
        //sRenderer.sprite = unit.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
