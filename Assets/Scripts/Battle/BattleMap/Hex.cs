using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Hex
{
    #region Fields
    public bool isWalkable;
    private GameObject _gameObject;
    public List<Hex> neighbours;
    public bool isVisited = false;
    public Hex previousHex = null;

    #endregion

    #region Properties
    public GameObject gameObject => _gameObject;
    #endregion

    #region Constructors
    public Hex(bool walkable, GameObject obj)
    {
        neighbours = new List<Hex>();
        isWalkable = walkable;
        _gameObject = obj;
    }
    #endregion
}
