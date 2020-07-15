using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    // temporary, scriptable object to load should be
    // recieved from battle initializer, as well as
    // amount and isEnemy
    [SerializeField] private int maxhp, attack, defense, magicdef, turns;
    [SerializeField] private bool canShoot;
    [SerializeField] private string unitName;

    [SerializeField] private int amount = 1;
    [SerializeField] private int health;
    [SerializeField] private bool isEnemy;
    //int healthOfUnit;

    public void Load(Warrior w, bool isEnemy) {
        maxhp = w.Hp;
        attack = w.AttackMight;
        defense = w.Armor;
        magicdef = w.MagicResistance;
        turns = w.TurnsAmount;
        canShoot = w.IsAbleToShoot;
        unitName = w.ClassName;

        this.amount = w.Amount;
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
