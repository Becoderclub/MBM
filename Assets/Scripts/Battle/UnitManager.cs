using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    [SerializeField] private GameObject unit;
    private Unit[] playerUnits = new Unit[PlayerArmy.armySize];

    // Start is called before the first frame update
    void Start()
    {
        PlayerArmy.Init();

        for (int i = 0; i < PlayerArmy.armySize; i++) {
            if (PlayerArmy.army[i] != null && PlayerArmy.army[i] != PlayerArmy.empty) {
                playerUnits[i] = new Unit(PlayerArmy.army[i], false);
                GameObject GO = Instantiate(unit);
                GO.transform.position = new Vector3(Random.Range(-1.5f, -3.0f), Random.Range(-2.5f, 2.5f), 0);
                playerUnits[i].gameObject = GO;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
