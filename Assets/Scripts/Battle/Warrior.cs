using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Warrior", menuName ="Warriors")]
public class Warrior : ScriptableObject
{
    //hp & attackMight is for every single unit of amount, so i must multiply it somewhere
    
    [SerializeField]public int hp {get;}
    [SerializeField]public int magicResistance{get;}
    [SerializeField]public int turnsAmount{get;}
    [SerializeField]public bool isAbleToShoot{get;}
    [SerializeField]public int attackMight{get;}
    [SerializeField]public int armor{get;}
    [SerializeField]public int worth{get;}
    
    [SerializeField]public string className{get;}
}