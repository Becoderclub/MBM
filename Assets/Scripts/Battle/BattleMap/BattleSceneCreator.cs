using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleSceneCreator : MonoBehaviour
{
    [SerializeField] private GameObject[] simpleHexes;
    [SerializeField] private GameObject[] obstacleHexes;
    [SerializeField] private int maxColumns = 13;
    [SerializeField] private int maxRows = 6;
    [SerializeField] private GameObject HexParent;
    [SerializeField] private Hex[,] BattleMap;
    private GameObject[,] HexObjects;
    bool toDecreaseY = true;
    void Awake()
    {
        HexObjects = new GameObject[maxColumns, maxRows];
        BattleMap = new Hex[maxColumns, maxRows];
        GenerateScene();
        GenerateBattleMap();
        SetNeighbours();
       
    }
    private void GenerateScene()
    {
        float x = -2.5f;
        float y = 2.5f;
        for (int column = 0; column < maxColumns; column++)
        {
            for (int row = 0; row < maxRows; row++)
            {
                if (column > 3 && column < 10 && Random.Range(1, 9) == 1)
                {
                    GameObject justSpawnedHex = Instantiate(obstacleHexes[Random.Range(0, obstacleHexes.Length)], new Vector3(x, y), Quaternion.identity);
                    justSpawnedHex.transform.parent = HexParent.transform;
                    justSpawnedHex.tag = "NotWalkable";
                    HexObjects[column, row] = justSpawnedHex;
                }
                else
                {
                    GameObject justSpawnedHex = Instantiate(simpleHexes[Random.Range(0, simpleHexes.Length)], new Vector3(x, y), Quaternion.identity);
                    justSpawnedHex.transform.parent = HexParent.transform;
                    justSpawnedHex.tag = "Walkable";
                    HexObjects[column, row] = justSpawnedHex;
                }
                y -= 0.9f;
            }
            
            if (toDecreaseY)
            {
                y = 2f;
            }
            else
            {
                y = 2.5f;
            }
            x += 0.75f;
            toDecreaseY = !toDecreaseY;
        }
    }
    private void GenerateBattleMap()
    {
        for(int x = 0; x < maxColumns; x++)
        {
            for (int y = 0; y < maxRows; y++)
            {
                List<Hex> neighbours = GetNeighbours(x, y);
                if(HexObjects[x, y].tag == "NotWalkable")
                {
                    BattleMap[x, y] = new Hex(false, HexObjects[x, y]);
                }
                else
                {
                    BattleMap[x, y] = new Hex(true, HexObjects[x, y]);
                }
            }
        }
    }
    private void SetNeighbours()
    {
        for (int x = 0; x < maxColumns; x++)
        {
            for (int y = 0; y < maxRows; y++)
            {
                List<Hex> neighbours = GetNeighbours(x, y);
                BattleMap[x, y].neighbours.AddRange(neighbours);
            }
        }
    }
    private List<Hex> GetNeighbours(int indexX, int indexY)
    {
        List<Hex> neighbours = new List<Hex>();

        if(indexX - 1 >= 0)
        {
            neighbours.Add(BattleMap[indexX - 1, indexY]);
            if(indexY - 1 >= 0)
            {
                neighbours.Add(BattleMap[indexX - 1, indexY - 1]);
            }
        }

        if(indexY - 1 >= 0)
        {
            neighbours.Add(BattleMap[indexX, indexY - 1]);
            if(indexX + 1 < maxColumns)
            {
                neighbours.Add(BattleMap[indexX + 1, indexY - 1]);
            }
        }

        if(indexX + 1 < maxColumns)
        {
            neighbours.Add(BattleMap[indexX + 1, indexY]);
        }
        
        if(indexY + 1 < maxRows)
        {
            neighbours.Add(BattleMap[indexX, indexY + 1]);
        }

        return neighbours;
    }
}
