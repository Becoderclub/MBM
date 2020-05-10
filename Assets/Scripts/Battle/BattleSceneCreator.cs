using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] simpleHexes;
    [SerializeField] GameObject[] obstacleHexes;
    [SerializeField] private int maxColumns;
    [SerializeField] private int maxRows;
    void Start()
    {
        
    }
    private void GenerateScene()
    {
        //TODO assign variables as first hex positions
        int x;
        int y;
        for (int column = 0; column<maxColumns; column++)
        {
            for (int rows = 0; rows<maxRows; rows++)
            {
                //todo
            }
        }
    }
}
