using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerArmy
{
    public const int armySize = 6;
    public static Warrior[] army;
    public static Warrior empty = ScriptableObject.CreateInstance<Warrior>();

    public static void Init() {
        // load army here, empty arr for now
        army = new Warrior[armySize];
        for (int i = 0; i < armySize; i++) {
            if (army[i] == null) {
                army[i] = empty;
            }
        }
    }

    public static void Swap(int a, int b) {
        Warrior tmp = army[a];
        army[a] = army[b];
        army[b] = tmp;
    }

    public static void Combine(int a, int b) {
        if (army[a].GetType() == army[b].GetType()) {
            army[a].Amount += army[b].Amount;
            army[b] = empty;
        }
    }

    public static void Separate(int src, int dest, int quan) {
        if (army[src].Amount > quan && army[dest] == empty) {
            army[dest] = army[src];
            army[dest].Amount = quan;
            army[src].Amount -= quan;
        }
    }
}