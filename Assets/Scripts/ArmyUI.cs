using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyUI : MonoBehaviour
{
    [SerializeField] private Slot[] slots = new Slot[PlayerArmy.armySize];
    private int selectedIndex;

    public enum States {
        Default,
        Swap,
        Combine,
        Separate
    }
    private States current;

    void OnEnable() {
        Slot.slotClicked += HandleSlotClick;
    }

    void Start() {
        PlayerArmy.Init();

        current = States.Default;
        for (int i = 0; i < PlayerArmy.armySize; i++) {
            slots[i].number = i;
        }
        Refresh();
    }

    public void Refresh() {
        for (int i = 0; i < PlayerArmy.armySize; i++) {
            slots[i].contentName.text = PlayerArmy.army[i].ClassName;
            // Warrior has no sprite field
            //slots[i].image.sprite = army[i].sprite;
        }
    }

    void HandleSlotClick(int slotnum) {
        if (current == States.Default) {
            selectedIndex = slotnum;
            // TODO: show options ui
        }
        else if (current == States.Swap) {
            PlayerArmy.Swap(selectedIndex, slotnum);
            current = States.Default;
        }
        else if (current == States.Separate) {
            // TODO: bring up the quantity menu, which will call
            // an action which will activate a method which will
            // call PlayerArmy.Separate
            current = States.Default;
        }
        else if (current == States.Combine) {
            PlayerArmy.Combine(selectedIndex, slotnum);
            current = States.Default;
        }
    }

    void ChangeState(States newState) {
        current = newState;
    }

    void OnDisable() {
        Slot.slotClicked -= HandleSlotClick;
    }
    void OnDestroy() {
        Slot.slotClicked -= HandleSlotClick;
    }
}