using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArmyCreator : MonoBehaviour
{
    [SerializeField]private List<Warrior> warriors;
    private void Awake()
    {
        warriors.Add(ScriptableObject.CreateInstance<Dwarf>());
        warriors.Add(ScriptableObject.CreateInstance<Wolf>());
        warriors.Add(ScriptableObject.CreateInstance<Elf>());
        warriors.Add(ScriptableObject.CreateInstance<Orc>());
        warriors.Add(ScriptableObject.CreateInstance<Giant>());
    }
    public List<Warrior> CreateArmy(int goalDifficulty, Transform parent)
    {
        List<Warrior> army = new List<Warrior>();
        int currentDifficulty = 0;
        while (currentDifficulty < goalDifficulty)
        {
            bool isSameClassObjectExsists = false;
            Warrior unitToAdd = warriors[Random.Range(0, warriors.Count)];
            string unitToAddName = unitToAdd.ClassName;
            Warrior warriorToIncreaseAmount = null;
            foreach (Warrior warriorGameObj in army)
            {
                if(warriorGameObj.ClassName == unitToAddName)
                {
                    isSameClassObjectExsists = true;
                    warriorToIncreaseAmount = warriorGameObj;
                    break;
                }
            }
            if (isSameClassObjectExsists)
            {
                warriorToIncreaseAmount.Amount = warriorToIncreaseAmount.Amount + 1;
            }
            else 
            { 
                army.Add(unitToAdd);
            }
            currentDifficulty += unitToAdd.Worth;
        }
        return army;
    }
}
