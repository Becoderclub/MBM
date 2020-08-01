using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyBattleController : MonoBehaviour
{
    [SerializeField] private GameObject unit;

    [SerializeField] private EnemyArmyCreator armyCreator;
    public List<Warrior> army;
    void Start()
    {
        // Player from the world must set EnemyDifficulty by getting difficulty from the Enemy 
        PlayerPrefs.SetInt("EnemyDifficulty", 25);
        army = NewArmy(PlayerPrefs.GetInt("EnemyDifficulty"));
        /*
        foreach (Warrior w in army) {
            GameObject tmp = Instantiate(unit);
            tmp.transform.position = new Vector3(UnityEngine.Random.Range(1.5f, 3.0f), UnityEngine.Random.Range(-2.5f, 2.5f), 0);
            tmp.GetComponent<Unit>().Load(w, true);
        }
        */
    }
    private List<Warrior> NewArmy(int difficulty)
    {
        return armyCreator.CreateArmy(difficulty);
    }
}
