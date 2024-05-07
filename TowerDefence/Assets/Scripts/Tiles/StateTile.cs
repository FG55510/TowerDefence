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
    public PoisonTile Pe;
    // Start is called before the first frame update
    void Start()
    {
        tile = EstadoTile.Normal;
        Pe = GetComponent<PoisonTile>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (tile)
        {
            case EstadoTile.Normal:
                EstadoConse(tile);
                break;
            case EstadoTile.PoisonEnemies:
                EstadoConse(tile);
                break;
            case EstadoTile.PoisonTower:
                EstadoConse(tile);
                break;
        }
    }

    public void MudarEstado(EstadoTile state)
    {
        tile = state;
    }

    public void EstadoConse(EstadoTile tipo)
    {
        switch (tipo) {
            case EstadoTile.Normal:
                Pe.enabled = false;
                break;
            case EstadoTile.PoisonEnemies:
                Pe.enabled = true;
                break;
            case EstadoTile.PoisonTower:
                break;
        }
    }

}
