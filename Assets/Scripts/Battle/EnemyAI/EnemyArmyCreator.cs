using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArmyCreator : MonoBehaviour
{
    [SerializeField]private List<Warrior> warriors;
    public List<Warrior> CreateArmy(int goalDifficulty)
    {
        List<Warrior> army = new List<Warrior>();
        int currentDifficulty = 0;
        
        while (currentDifficulty < goalDifficulty)
        {
            bool isSameClassObjectExsists = false;
            Warrior unitToAdd = warriors[Random.Range(0, warriors.Count)];
            string unitToAddName = unitToAdd.ClassName;
            Warrior warriorToIncreaseAmount = null;

            
            if (unitToAddName == "Dwarf")
            {
                unitToAdd = ScriptableObject.CreateInstance<Dwarf>();
            }
            else if (unitToAddName == "Elf")
            {
                unitToAdd = ScriptableObject.CreateInstance<Elf>();
            }
            else if (unitToAddName == "Giant")
            {
                unitToAdd = ScriptableObject.CreateInstance<Giant>();
            }
            else if (unitToAddName == "Orc")
            {
                unitToAdd = ScriptableObject.CreateInstance<Orc>();
            }
            else if (unitToAddName == "Wolf")
            {
                unitToAdd = ScriptableObject.CreateInstance<Wolf>();
            }

            if(unitToAdd != null)
            {
                foreach (Warrior war in warriors)
                {
                    if (war.ClassName == unitToAddName)
                    {
                        unitToAdd.Armor = war.Armor;
                        unitToAdd.AttackMight = war.AttackMight;
                        unitToAdd.Hp = war.Hp;
                        unitToAdd.IsAbleToShoot = war.IsAbleToShoot;
                        unitToAdd.MagicResistance = war.MagicResistance;
                        unitToAdd.TurnsAmount = war.TurnsAmount;
                        unitToAdd.Worth = war.Worth;
                        unitToAdd.Amount = 1;
                        unitToAdd.ClassName = unitToAddName;
                    }
                }
            }

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
