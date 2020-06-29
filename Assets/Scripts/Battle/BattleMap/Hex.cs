using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex
{
    #region Fields
    private bool _isWalkable;
    private GameObject _gameObject;
    private List<Hex> _neighbours;
    #endregion

    #region Properties
    public bool isWalkable => _isWalkable;
    public GameObject gameObject => _gameObject;
    public List<Hex> neighbours => _neighbours;
    #endregion

    #region Constructors
    public Hex(bool walkable, GameObject obj, List<Hex> neighbourHexes)
    {
        _neighbours = new List<Hex>();
        _isWalkable = walkable;
        _gameObject = obj;
        _neighbours.AddRange(neighbourHexes);
    }
    #endregion
}
