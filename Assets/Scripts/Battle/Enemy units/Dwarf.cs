using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dwarf : Warrior
{
    public Dwarf()
    {
        className = "Dwarf";
        hp = 70;
        isEnemy = true;
        magicResistance = 30;
        turnsAmount = 2;
        isAbleToShoot = false;
        attackMight = 100;
        armor = 5;
        worth = 4;
    }
}
