using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitCreator : MonoBehaviour
{
    [SerializeField] private GameObject unit;
    [SerializeField] private EnemyBattleController ebcontroller;

    // Start is called before the first frame update
    void Start()
    {
        PlayerArmy.Init();

        foreach (Warrior w in ebcontroller.army) {
            GameObject tmp = Instantiate(unit);
            tmp.transform.position = new Vector3(Random.Range(1.5f, 3.0f), Random.Range(-2.5f, 2.5f), 0);
            tmp.GetComponent<Unit>().Load(w, true);
        }

        foreach (Warrior w in PlayerArmy.army) {
            if (w != null && w != PlayerArmy.empty) {
                GameObject tmp = Instantiate(unit);
                tmp.transform.position = new Vector3(Random.Range(-1.5f, -3.0f), Random.Range(-2.5f, 2.5f), 0);
                tmp.GetComponent<Unit>().Load(w, false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
