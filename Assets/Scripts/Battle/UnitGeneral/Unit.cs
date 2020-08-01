using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unit
{
    private int baseHealth, baseAttack, defense, magicdef, turns;
    private bool canShoot;
    private string unitName;

    private int amount = 1;
    private int totalHealth;
    private int totalAttack;
    private bool isEnemy;

    public string UnitName
    {
        get => unitName;
    }
    public int TotalHealth
    {
        get => totalHealth;
    }
    public int Amount
    {
        get => amount;
    }

    public int healthOfUnit;
    public Sprite sprite;
    public GameObject gameObject;

    public Unit(Warrior warrior, bool isEnemy) {
        baseHealth = warrior.Hp;
        baseAttack = warrior.AttackMight;
        defense = warrior.Armor;
        magicdef = warrior.MagicResistance;
        turns = warrior.TurnsAmount;
        canShoot = warrior.IsAbleToShoot;
        unitName = warrior.ClassName;
        this.sprite = warrior.Sprite;

        this.amount = warrior.Amount;
        this.isEnemy = isEnemy;
        totalHealth = baseHealth * amount;
        totalAttack = baseAttack * amount;
        healthOfUnit = baseHealth;
    }
}