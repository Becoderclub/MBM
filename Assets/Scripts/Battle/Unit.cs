using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    int maxhp, attack, defense, magicdef, turns;
    bool canShoot;
    string unitName;

    int amount = 1;
    int health;
    bool isEnemy;
    //int healthOfUnit;

    void Load(Warrior w, int amount, bool isEnemy) {
        maxhp = w.hp;
        attack = w.attackMight;
        defense = w.armor;
        magicdef = w.magicResistance;
        turns = w.turnsAmount;
        canShoot = w.isAbleToShoot;
        unitName = w.className;

        this.amount = amount;
        this.isEnemy = isEnemy;
        health = maxhp * amount;
        //healthOfUnit = maxhp;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
