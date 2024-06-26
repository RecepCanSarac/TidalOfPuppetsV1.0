using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu(fileName = "Tower", menuName = "Towers/AttackTower")]
public class SOTower : ScriptableObject
{
    [Header("TowerName")]
    public string TowerName; 

    [Header("TowerLevel")]
    public int TowerLevel;

    [Header("TowerObject")]
    public GameObject[] prefab;

    [Header("TowerAttributes")]
    public float[] AttackRange;
    public float[] AttackRate;


    [Header("TowerUI")]
    public Sprite[] towerImage;


    [Header("Tower Description")]
    public string[] Description;
}
