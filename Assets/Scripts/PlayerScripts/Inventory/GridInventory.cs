using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GridInventory : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private Text _itemName;
    [SerializeField] private Image _itemIcon;

    private Transform _draggingParent;
    private Transform _originalParent;
    
    public void Init(Transform draggingParent)
    {
        _draggingParent = draggingParent;
        _originalParent = transform.parent;
    }

    public void RenderList(IItem item)
    {
        _itemName.text = item.Name;
        _itemIcon.sprite = item.Icon; 
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.parent = _draggingParent;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        int theClosestIndex = 0;

        for (int i = 0; i < _originalParent.transform.childCount; i++)
        {
            if (Vector3.Distance(transform.position, _originalParent.GetChild(i).position) <
               (Vector3.Distance(transform.position, _originalParent.GetChild(theClosestIndex).position)))
            {
                theClosestIndex = i;
            }
        }

        transform.parent = _originalParent;
        transform.SetSiblingIndex(theClosestIndex); // set new object index in this hierarchy;
    }
}
