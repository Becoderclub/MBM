using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Warrior
{
    public Elf()
    {
        className = "Elf";
        hp = 50;
        isEnemy = true;
        magicResistance = 30;
        turnsAmount = 2;
        isAbleToShoot = true;
        attackMight = 100;
        armor = 0;
        worth = 3;
    }
}
