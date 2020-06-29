using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableInventory : MonoBehaviour
{
    private Canvas _canvas;
    void Start()
    {
        _canvas = GetComponent<Canvas>();
        _canvas.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            _canvas.enabled = !_canvas.enabled;
        }
    }
}
