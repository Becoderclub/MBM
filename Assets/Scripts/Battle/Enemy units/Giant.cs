using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giant : Warrior
{
    public Giant()
    {
        className = "Giant";
        hp = 300;
        isEnemy = true;
        magicResistance = 15;
        turnsAmount = 1;
        isAbleToShoot = true;
        attackMight = 70;
        armor = 15;
        worth = 5;
    }
}
