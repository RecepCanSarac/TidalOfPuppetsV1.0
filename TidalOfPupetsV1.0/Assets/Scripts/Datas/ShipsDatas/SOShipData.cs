using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Ship",menuName ="Ships")]
public class SOShipData : ScriptableObject
{
    public int ShipLevel = 0;

    public List<SOTower> ShipDatas;
    public List<GameObject> SlotList;
    public List<Vector2> SlotPoints;

    public SOShipData() { }
}
