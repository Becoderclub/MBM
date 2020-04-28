using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Warrior
{
    public Orc()
    {
        className = "Orc";
        hp = 50;
        isEnemy = true;
        magicResistance = 30;
        turnsAmount = 2;
        isAbleToShoot = false;
        attackMight = 100;
        armor = 0;
        worth = 2;
    }
}
