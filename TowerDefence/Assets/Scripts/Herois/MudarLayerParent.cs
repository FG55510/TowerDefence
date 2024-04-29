using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Mathematics;

public class MudarLayerParent : MonoBehaviour
{
    public enum tile{
        Heroi,
        Torre
    }

    public tile tipo;
    public LayerMask mask;

    public void Final(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, math.INFINITY,mask);
        
        if(tipo == tile.Heroi){
            hit.collider.gameObject.layer = LayerMask.NameToLayer("TilePath");
        }
        else {
            hit.collider.gameObject.layer = LayerMask.NameToLayer("TileNormal");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
