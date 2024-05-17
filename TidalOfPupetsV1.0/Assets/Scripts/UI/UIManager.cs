using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public DamagerCardFactory damageCardFactory;

    public Transform parent;

    //enum CardTypes { DamageCard00, DamageCard01, DamageCard02 }
    //CardTypes cardTypes = CardTypes.DamageCard00;
    public void GetCard(int id )
    {
        damageCardFactory.GetCard(id,parent);
    }
}
