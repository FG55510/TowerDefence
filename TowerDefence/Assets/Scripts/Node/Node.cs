using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public static Action<Node> OnNodeSelected;

    public Heroi Tower { get; set; }

    public void SetTower(Heroi tower)
    {
        Tower = tower;
    }

    public bool IsEmpty()
    {
        return Tower == null;
    }

    public void SelectTower()
    {
        OnNodeSelected?.Invoke(this);
    }
}
