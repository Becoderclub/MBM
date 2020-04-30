using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArmyCreator : MonoBehaviour
{
    [SerializeField]private List<GameObject> warriors;
    public List<GameObject> CreateArmy(int goalDifficulty, Transform parent)
    {
        List<GameObject> army = new List<GameObject>();
        int currentDifficulty = 0;
        while (currentDifficulty < goalDifficulty)
        {
            bool isSameClassObjectExsists = false;
            GameObject unitToAdd = warriors[Random.Range(0, warriors.Count)];
            string unitToAddName = unitToAdd.GetComponent<Warrior>().ClassName;
            Warrior warriorToIncreaseAmount = null;
            foreach (GameObject warriorGameObj in army)
            {
                if(warriorGameObj.GetComponent<Warrior>().ClassName == unitToAddName)
                {
                    isSameClassObjectExsists = true;
                    warriorToIncreaseAmount = warriorGameObj.GetComponent<Warrior>();
                    break;
                }
            }
            if (isSameClassObjectExsists)
            {
                Debug.Log(warriorToIncreaseAmount.Amount);
                warriorToIncreaseAmount.Amount = warriorToIncreaseAmount.Amount + 1;
                Debug.Log(warriorToIncreaseAmount.Amount);
            }
            else 
            { 
                GameObject unitInArmy = Instantiate(unitToAdd, parent);
                army.Add(unitInArmy);
            }
            currentDifficulty += unitToAdd.GetComponent<Warrior>().Worth;
        }
        return army;
    }
}
