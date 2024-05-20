using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSlot : MonoBehaviour
{
    public bool isActive = false;

    public void InstantiateTurret(SOTower tower)
    {
        GameObject turret = Instantiate(tower.prefab[tower.TowerLevel]);
        turret.transform.position = transform.position;
    }
}
