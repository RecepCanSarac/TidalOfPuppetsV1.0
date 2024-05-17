using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardDrop : MonoBehaviour , IDropHandler
{

    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag; 
        CardDrag draggableItem = dropped.GetComponent<CardDrag>();
        draggableItem.parentAfterDrag = transform;
    }

    
}
