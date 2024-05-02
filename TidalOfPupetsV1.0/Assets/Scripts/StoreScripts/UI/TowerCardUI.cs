using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TowerCardUI : MonoBehaviour
{
    public RectTransform towerClassCards;
    private Vector2 originalPosition;

    private bool isMoved = false; 

    private void Start()
    {
       
        originalPosition = towerClassCards.anchoredPosition;
    }

    public void GetClassCart()
    {
        if (isMoved)
        {
            
            towerClassCards.DOAnchorPos(originalPosition, 1f);
            isMoved = false; 
        }
        else
        {
            // E�er panel hen�z hareket etmemi�se, sa�a do�ru kayd�r
            Vector2 targetPosition = new Vector2(450, towerClassCards.anchoredPosition.y); 
            towerClassCards.DOAnchorPos(targetPosition, 1f);
            isMoved = true; // Bayra�� ayarla
        }
    }
}
