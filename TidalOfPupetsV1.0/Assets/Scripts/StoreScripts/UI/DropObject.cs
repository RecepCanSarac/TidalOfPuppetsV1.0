using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropObject : MonoBehaviour, IDropHandler
{
    public Image panel;
    public Sprite tower;
    public Sprite Sprite;
    public TextMeshProUGUI text;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject droppedObj = eventData.pointerDrag;

        panel.sprite = tower;
    }


}
