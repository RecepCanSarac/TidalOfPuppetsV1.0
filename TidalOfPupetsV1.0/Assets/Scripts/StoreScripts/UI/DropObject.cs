using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropObject : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObj = eventData.pointerDrag;
        DragObject draggaItem = droppedObj.GetComponent<DragObject>();
        draggaItem.parentTransform = transform;
        draggaItem.discart = false;
        TowerCardSetup card = droppedObj.GetComponent<TowerCardSetup>();

        this.GetComponent<Image>().sprite = card.tower.towerImage[card.TowerLevel];
    }
}