using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipManagerScript : MonoBehaviour
{
    public List<SOTower> Towers = new List<SOTower>();

    
    public void GetTowerObject(GameObject _tower, Transform _transform)
    {
        Vector3 _position = Input.mousePosition;
        _position.z = Camera.main.nearClipPlane; 
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(_position);
        GameObject towerObj = Instantiate(_tower, worldPosition, Quaternion.identity);
        towerObj.transform.parent = _transform;
    }
}
