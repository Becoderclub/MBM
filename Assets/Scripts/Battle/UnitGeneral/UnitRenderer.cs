using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(SpriteRenderer))]
public class UnitRenderer : MonoBehaviour
{
    public static Action OnAmountChange;
    public static Action OnHealthChange;

    [SerializeField] private GameObject TextObject;
    [SerializeField] private GameObject Healthbar;

    private float startScale;
    private float currentScale;
    private string text;
    private SpriteRenderer sRenderer;
    public Unit unit;

    // Start is called before the first frame update
    private void Start()
    {
        OnAmountChange += UpdateAmount;
        OnHealthChange += UpdateHealthbar;

        startScale = Healthbar.transform.localScale.x;
        currentScale = Healthbar.transform.localScale.x;

        sRenderer = GetComponent<SpriteRenderer>();
        sRenderer.sprite = unit.sprite;
        text = TextObject.GetComponent<TextMesh>().text;
        text = unit.UnitName + ", " + unit.Amount;
    }

    private void UpdateAmount()
    {
        text = unit.UnitName + ", " + unit.Amount;
    }

    private void UpdateHealthbar()
    {
        // create a multiplier for healthbar size
        // int hpPart = unit.currentHeath / unit.totalHealth;
        // currentScale = startScale * hpPart;
    }

}
