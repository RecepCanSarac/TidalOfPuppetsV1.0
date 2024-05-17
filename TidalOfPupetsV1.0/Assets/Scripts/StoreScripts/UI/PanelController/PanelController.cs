using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PanelController : MonoBehaviour
{
    public GameObject cardClassPanel;

    private float duration = 1f;

    public void GetClass(int id)
    {
        Quaternion targetRotation = Quaternion.Euler(0f, -180f, 0f);

        cardClassPanel.GetComponent<RectTransform>().DORotate(targetRotation.eulerAngles, duration)
            .SetEase(Ease.Linear);
    }

    public void ReturnCardClass()
    {
        Quaternion targetRotation = Quaternion.Euler(0f, 0f, 0f);

        cardClassPanel.GetComponent<RectTransform>().DORotate(targetRotation.eulerAngles, duration)
            .SetEase(Ease.Linear);
    }
}
