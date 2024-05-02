using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    /// <summary>
    /// OnPointerDown T�kland���nda Ger�ekle�tir �al���r
    /// OnBeginDrag S�r�kleme ��lemi Ba�lad���nda �al���r
    /// OnEndDrag S�r�kleme Bitti�inde �al���r
    /// OnDrag S�r�klerken �al���r
    /// </summary>

    private RectTransform m_RectTransform;
    private Transform parentTransform;
    
    private void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("T�kland�");
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        parentTransform = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentTransform);
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition += eventData.delta;

    }
}
