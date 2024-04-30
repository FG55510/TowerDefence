using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EstadoTile
{
    Normal,
    PoisonEnemies,
    PoisonTower
}
public class StateTile : MonoBehaviour
{
    public EstadoTile tile;
    public PoisonTile pe;
    // Start is called before the first frame update
    void Start()
    {
        tile = EstadoTile.Normal;
        pe = GetComponent<PoisonTile>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (tile)
        {
            case EstadoTile.Normal:
                break;
            case EstadoTile.PoisonEnemies:
                break;
            case EstadoTile.PoisonTower:
                break;
        }
    }

}
