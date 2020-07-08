using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Hex
{
    #region Fields
    [SerializeField] private bool _isWalkable;
    [SerializeField] private GameObject _gameObject;
    public List<Hex> neighbours;
    #endregion

    #region Properties
    public bool isWalkable => _isWalkable;
    public GameObject gameObject => _gameObject;
    #endregion

    #region Constructors
    public Hex(bool walkable, GameObject obj)
    {
        neighbours = new List<Hex>();
        _isWalkable = walkable;
        _gameObject = obj;
    }
    #endregion
}
