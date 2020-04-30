using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<ItemImplementation> Items;
    [SerializeField] private GridInventory _gridInventoryTemplate;
    [SerializeField] private Transform _container;

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
        foreach (ItemImplementation item in Items)
        {
            var cell = Instantiate(_gridInventoryTemplate, _container);
            cell.RenderList(item);
        }
    }
}
