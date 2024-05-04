using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TowerCardSetup : MonoBehaviour
{
    [SerializeField] Image Sprite;
    [SerializeField] TextMeshProUGUI desc;
    [SerializeField] Button bulletButton;

    public SOBasicTower tower;

    public int TowerLevel = 0;
    private void Start()
    {
        Setup();
    }
    public void Setup()
    {
        Sprite.sprite = tower.towerImage[TowerLevel];
        desc.text = tower.Description[TowerLevel];
    }
}
