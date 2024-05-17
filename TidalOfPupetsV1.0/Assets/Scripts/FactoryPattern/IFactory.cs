using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFactory
{
    public IProduct GetCard(int cardId, Transform parent);
}
