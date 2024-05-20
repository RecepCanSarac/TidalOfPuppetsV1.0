using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManager : MonoBehaviour
{
    public List<SOTower> TowerData;
    public List<TowerSlot> SlotList;
    public List<Vector2> SlotPoints;

    public ShipManager()
    {
        for (int i = 0; i < SlotList.Count; i++)
        {
            if (SlotList[i].isActive == true)
            {
                SlotList[i].InstantiateTurret(TowerData[i]);
                Debug.Log(SlotList[i].isActive);
            }
        }
    }
}
