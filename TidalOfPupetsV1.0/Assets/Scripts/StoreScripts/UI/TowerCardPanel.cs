using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TowerCardPanel : MonoBehaviour,IDropHandler
{
    int childNumber;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dragItem = eventData.pointerDrag;

        dragItem.GetComponent<DragObject>().discart = true;
    }

    private void Update()
    {
        if (transform.childCount < 1)
        {
            Debug.Log(childNumber = 0);
        }
        else if (transform.childCount == 1)
        {
            Debug.Log(childNumber = 1);
        }
    }


}
