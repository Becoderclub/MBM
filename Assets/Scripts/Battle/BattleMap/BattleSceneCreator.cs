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
    private List<Hex> BattleMap;
    private List<GameObject> HexObjects;
    bool toDecreaseY = true;
    void Awake()
    {
        HexObjects = new List<GameObject>();
        BattleMap = new List<Hex>();
        GenerateScene();
    }
    private void GenerateScene()
    {
        float x = -2.5f;
        float y = 2.5f;
        for (int column = 0; column<maxColumns; column++)
        {
            for (int rows = 0; rows<maxRows; rows++)
            {
                if (column > 3 && column < 10 && Random.Range(1, 9) == 1)
                {
                    GameObject justSpawnedHex = Instantiate(obstacleHexes[Random.Range(0, obstacleHexes.Length)], new Vector3(x, y), Quaternion.identity);
                    justSpawnedHex.transform.parent = HexParent.transform;
                    justSpawnedHex.tag = "NotWalkable";
                    HexObjects.Add(justSpawnedHex);
                }
                else
                {
                    GameObject justSpawnedHex = Instantiate(simpleHexes[Random.Range(0, simpleHexes.Length)], new Vector3(x, y), Quaternion.identity);
                    justSpawnedHex.transform.parent = HexParent.transform;
                    justSpawnedHex.tag = "Walkable";
                    HexObjects.Add(justSpawnedHex);
                }
            }
            y -= 0.9f;
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
    private void CreateBatlleMap()
    {

    }
}
