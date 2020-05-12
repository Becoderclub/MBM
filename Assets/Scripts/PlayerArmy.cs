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
        army[0] = ScriptableObject.CreateInstance<Elf>();
    }
}