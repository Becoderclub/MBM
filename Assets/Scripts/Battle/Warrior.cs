using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Warrior", menuName ="Warriors")]
public class Warrior : ScriptableObject
{
    //hp & attackMight is for every single unit of amount, so i must multiply it somewhere
    #region Fields
    [SerializeField] private int hp;
    [SerializeField] private int magicResistance;
    [SerializeField] private int turnsAmount;
    [SerializeField] private bool isAbleToShoot;
    [SerializeField] private int attackMight;
    [SerializeField] private int armor;
    [SerializeField] private int worth;
    [SerializeField] private int amount;
    [SerializeField] private string className;
    #endregion

    #region Properties
    public int Hp { get { return hp; } set { hp = value; } }
    public int MagicResistance { get { return magicResistance; } set { magicResistance = value; } }
    public int TurnsAmount { get { return turnsAmount; } set { turnsAmount = value; } }
    public bool IsAbleToShoot { get { return isAbleToShoot; } set { isAbleToShoot = value; } }
    public int AttackMight { get { return attackMight; } set { attackMight = value; } }
    public int Armor { get { return armor; } set { armor = value; } }
    public int Worth { get { return worth; } set { worth = value; } }
    public int Amount { get { return amount; } set { amount = value; } }
    public string ClassName { get { return className; } set { className = value; } }
    #endregion
}