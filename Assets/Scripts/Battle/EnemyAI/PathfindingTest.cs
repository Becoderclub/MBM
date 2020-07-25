using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathfindingTest : MonoBehaviour
{
    [SerializeField] private BattleSceneCreator battleSceneCreator;
    List<Hex> path;
    void Start()
    {
        path = Pathfinding.FindPath(battleSceneCreator.BattleMap[0, 0], battleSceneCreator.BattleMap[1, 2]);
        Debug.Log(path.Count);
    }

    private void OnDrawGizmos()
    {
        for (int i = 0; i < path.Count; i++)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawSphere(path[i].gameObject.transform.position, 0.1f + 0.05f * i);
        }
    }

}
