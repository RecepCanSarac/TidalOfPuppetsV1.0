using System.Security.Policy;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragObject : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{

    /// <summary>
    /// OnPointerDown Týklandýðýnda Gerçekleþtir Çalýþýr
    /// OnBeginDrag Sürükleme Ýþlemi Baþladýðýnda Çalýþýr
    /// OnEndDrag Sürükleme Bittiðinde Çalýþýr
    /// OnDrag Sürüklerken çalýþýr
    /// </summary>

    private RectTransform m_RectTransform;
    [HideInInspector]public  Transform parentTransform;
    public Image raycast;
    public bool discart = true;



    public GameObject panel;
    public Image sprite;
    public TextMeshProUGUI text;
    public Button btn;


    private void Awake()
    {
        m_RectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        if (discart == true)
        {
            panel.GetComponent<Image>().enabled = true;
            sprite.GetComponent<Image>().enabled = true;
            text.enabled = true;
            btn.gameObject.SetActive(true);
        }
        else
        {
            panel.GetComponent<Image>().enabled = false;
            sprite.GetComponent<Image>().enabled = false;
            text.enabled = false;
            btn.gameObject.SetActive(false);
        }
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
        raycast.raycastTarget = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(parentTransform);
        raycast.raycastTarget = true;
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        m_RectTransform.anchoredPosition += eventData.delta;

    }
}
