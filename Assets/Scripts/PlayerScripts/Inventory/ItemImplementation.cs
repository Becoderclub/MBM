using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemImplementation", menuName = "Item")]
public class ItemImplementation : ScriptableObject, IItem
{
    public string Name => _name;
    public Sprite Icon => _icon;

    [SerializeField] private string _name;
    [SerializeField] private Sprite _icon;
}
