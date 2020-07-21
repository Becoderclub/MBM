using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Pathfinding
{
    public static List<Hex> FindPath(Hex start, Hex goal)
    {
        List<Hex> path = new List<Hex>();
        Queue<Hex> waitingNodes = new Queue<Hex>();
        bool toBreak = false;
        waitingNodes.Enqueue(start);
        start.isVisited = true;
        if(start == goal)
        {
            return null;
        }
        while (waitingNodes.Count > 0)
        {
            Hex current = waitingNodes.Dequeue();
            foreach(Hex neighbour in current.neighbours)
            {
                if (!neighbour.isVisited && neighbour.isWalkable)
                {
                    neighbour.previousHex = current;
                    neighbour.isVisited = true;
                    if(neighbour == goal)
                    {
                        path = CalculatePath(neighbour);
                        toBreak = true;
                        break;
                    }
                    else
                    {
                        waitingNodes.Enqueue(neighbour);
                    }
                }
            }
            if (toBreak)
            {
                break;
            }
        }

        return path;
    }
    public static List<Hex> CalculatePath(Hex goalNode)
    {
        List<Hex> path = new List<Hex>();
        Hex current = goalNode;
        while (current.previousHex != null)
        {
            path.Add(current);
            current = current.previousHex;
        }
        path.Add(current);
        path.Reverse();
        return path;
    }
}
