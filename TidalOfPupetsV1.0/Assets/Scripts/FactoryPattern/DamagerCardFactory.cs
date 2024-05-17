using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagerCardFactory : MonoBehaviour, IFactory
{
    public int EnventoryCapastiy = 3;


    [SerializeField] private GameObject damageCard00;
    [SerializeField] private GameObject damageCard01;
    public const int DamagerCartType00 = 0;
    public const int DamagerCartType01 = 1;

    public IProduct GetCard(int cardId, Transform parent)
    {
        switch (cardId)
        {
            case DamagerCartType00:
                var card00 = Instantiate(damageCard00);
                card00.transform.SetParent(parent);
                card00.transform.SetAsFirstSibling();
                card00.GetComponent<RectTransform>().localScale = Vector3.one;
                return new DamageCard00();
            case DamagerCartType01:
                var card01 = Instantiate(damageCard01);
                card01.transform.SetParent(parent);
                card01.transform.SetAsFirstSibling();
                card01.GetComponent<RectTransform>().localScale = Vector3.one;
                return new DamageCard00();
        }
        return null;
    }
}


public class DamageCard00 : IProduct
{
    private string cardType = "";
    string IProduct.CardType => cardType;

    void IProduct.Initialize()
    {
        cardType = "DamageCard 00";
    }
}
public class DamageCard01 : IProduct
{
    private string cardType = "";
    string IProduct.CardType => cardType;

    void IProduct.Initialize()
    {
        cardType = "DamageCard 01";
    }
}