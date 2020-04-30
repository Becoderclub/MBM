using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : ScriptableObject
{
    //hp attackMight magicResistance is for every single unit of amount
    [SerializeField]protected int amount = 1;
    public int Amount
    {
        get => amount;
        set => amount = value;
    }
    protected int hp = 100;
    protected bool isEnemy = false;
    protected int magicResistance = 0;
    protected int turnsAmount = 1;
    protected bool isAbleToShoot = false;
    protected int attackMight = 70;
    protected int armor = 5;
    protected int worth = 5;
    public int Worth
    {
        get => worth;
    }
    protected string className = "Default";
    public string ClassName
    {
        get => className;
    }
}
