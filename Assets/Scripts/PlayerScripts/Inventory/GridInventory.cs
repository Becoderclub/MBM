using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridInventory : MonoBehaviour
{
    [SerializeField] private Text _itemName;
    [SerializeField] private Image _itemIcon;
    
    public void RenderList(IItem item)
    {
        _itemName.text = item.Name;
        _itemIcon.sprite = item.Icon; 
    }
}
