using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragObject : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    /// <summary>
    /// OnPointerDown Týklandýðýnda Gerçekleþtir Çalýþýr
    /// OnBeginDrag Sürükleme Ýþlemi Baþladýðýnda Çalýþýr
    /// OnEndDrag Sürükleme Bittiðinde Çalýþýr
    /// OnDrag Sürüklerken çalýþýr
    /// </summary>

    private RectTransform m_RectTransform;
    private Transform parentTransform;
    
    private void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Týklandý");
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
