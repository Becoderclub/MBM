using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<ItemImplementation> Items;
    [SerializeField] private GridInventory _gridInventoryTemplate;
    [SerializeField] private Transform _container;
    [SerializeField] private Transform _draggingParent;
    private void OnEnable() 
    {
        RenderList(Items);
    }
    private void RenderList(List<ItemImplementation> items)
    {
        foreach (Transform pos in _container)
        {
            Destroy(pos.gameObject);
        }
        foreach (ItemImplementation item in items)
        {
            var cell = Instantiate(_gridInventoryTemplate, _container);
            cell.Init(_draggingParent);
            cell.RenderList(item);
        }
    }
}
