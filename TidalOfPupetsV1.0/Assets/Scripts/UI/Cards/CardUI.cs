using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    public SOTower Tower;

    [SerializeField] private Image towerImage;
    [SerializeField] private TextMeshProUGUI className;
    [SerializeField] private TextMeshProUGUI towerDesc;

    private void Start()
    {
        SetupCard(Tower);
    }
    public void SetupCard(SOTower _tower)
    {
        towerImage.sprite = _tower.towerImage[_tower.TowerLevel];
        className.text = _tower.TowerName;
        towerDesc.text = _tower.Description[_tower.TowerLevel];
    }
}
