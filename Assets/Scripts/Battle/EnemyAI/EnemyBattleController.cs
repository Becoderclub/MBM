using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBattleController : MonoBehaviour
{
    [SerializeField] private EnemyArmyCreator armyCreator;
    public List<Warrior> army;
    void Start()
    {
        PlayerPrefs.SetInt("EnemyDifficulty", 25);
        army = NewArmy(PlayerPrefs.GetInt("EnemyDifficulty"));
    }
    private List<Warrior> NewArmy(int difficulty)
    {
        return armyCreator.CreateArmy(difficulty);
    }
}
