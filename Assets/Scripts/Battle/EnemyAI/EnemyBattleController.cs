using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBattleController : MonoBehaviour
{
    [SerializeField] private EnemyArmyCreator armyCreator;
    public List<GameObject> army;
    private int difficulty;
    void Start()
    {
        difficulty = 25;
        army = armyCreator.CreateArmy(difficulty, transform);
    }
}
