using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarLayerParent : MonoBehaviour
{
    public enum tile{
        Heroi,
        Torre
    }

    public tile tipo;

    public void Final(){
        if(tipo == tile.Heroi){
            transform.parent.gameObject.layer = LayerMask.NameToLayer("TilePath");
        }
        else {
            transform.parent.gameObject.layer = LayerMask.NameToLayer("TileNormal");
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
