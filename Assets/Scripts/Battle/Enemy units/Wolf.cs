using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : Warrior
{
    public Wolf()
    {
        className = "Wolf";
        hp = 70;
        isEnemy = true;
        magicResistance = 0;
        turnsAmount = 2;
        isAbleToShoot = false;
        attackMight = 30;
        armor = 0;
        worth = 1;
    }
}
