using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Warrior", menuName ="Warriors")]
public class Warrior : ScriptableObject
{
    //hp & attackMight is for every single unit of amount, so i must multiply it somewhere
    [SerializeField]protected int amount;
    
    [SerializeField]protected int hp;
    [SerializeField]protected bool isEnemy;
    [SerializeField]protected int magicResistance;
    [SerializeField]protected int turnsAmount;
    [SerializeField]protected bool isAbleToShoot;
    [SerializeField]protected int attackMight;
    [SerializeField]protected int armor;
    [SerializeField]protected int worth;
    
    [SerializeField]protected string className;
    public string ClassName
    {
        get => className;
    }
    public int Amount
    {
        get => amount;
        set => amount = value;
    }
    public int Worth
    {
        get => worth;
    }
}
