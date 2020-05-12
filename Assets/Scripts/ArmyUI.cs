using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyUI : MonoBehaviour
{
    [SerializeField] private Slot[] slots = new Slot[PlayerArmy.armySize];

    void Start() {
        PlayerArmy.Init();
        Refresh();
    }

    public void Refresh() {
        for (int i = 0; i < PlayerArmy.armySize; i++) {
            slots[i].contentName.text = PlayerArmy.army[i].ClassName;
            // Warrior has no sprite field
            //slots[i].image.sprite = army[i].sprite;
        }
    }
}