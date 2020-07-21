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

    private GameObject[,] HexObjects;
    private bool toDecreaseY = true;

    public Hex[,] BattleMap;
    
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
                GenerateTile(column, row, x, y);

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

    private void GenerateTile(int xIndex, int yIndex, float x, float y)
    {
        GameObject justSpawnedHex;
        if (x > 3 && x < 10 && Random.Range(1, 9) == 1)
        {
            justSpawnedHex = Instantiate(obstacleHexes[Random.Range(0, obstacleHexes.Length)], new Vector3(x, y), Quaternion.identity);
            justSpawnedHex.tag = "NotWalkable";
        }
        else
        {
            justSpawnedHex = Instantiate(simpleHexes[Random.Range(0, simpleHexes.Length)], new Vector3(x, y), Quaternion.identity);
            justSpawnedHex.tag = "Walkable";
        }
        HexObjects[xIndex, yIndex] = justSpawnedHex;
        justSpawnedHex.transform.parent = HexParent.transform;
    }

    private void GenerateBattleMap()
    {
        for (int x = 0; x < maxColumns; x++)
        {
            for (int y = 0; y < maxRows; y++)
            {
                List<Hex> neighbours = GetNeighbours(x, y);

                if (HexObjects[x, y].tag == "NotWalkable")
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

        bool isOdd = indexX % 2 == 0 ? true : false;

        

        return neighbours;
    }
}

public class Index2D
{
    int x;
    int y;
    public Index2D(int xIndex, int yIndex)
    {
        x = xIndex;
        y = yIndex;
    }
}
