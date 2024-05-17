using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBuy : MonoBehaviour
{
    public GameObject buyPanel;

    private void Update()
    {
        transform.SetAsLastSibling();
    }

    public void OpenPanel()
    {
        buyPanel.SetActive(true);
    }


    public void ClosePanel()
    {
        buyPanel.SetActive(false);
    }
}
