using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

[Serializable]
public class AttributeTower 
{
    public string name;
    public int cost;
    public GameObject prefabTower;

    public AttributeTower (string _name, int _cost, GameObject _prefabTower)
    {
        name = _name;
        cost = _cost;
        prefabTower = _prefabTower;
    }
        
}
