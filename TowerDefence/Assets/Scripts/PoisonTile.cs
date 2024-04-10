using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoisonTile : MonoBehaviour
{
    public Color ogcolor;
    public SpriteRenderer sr;

    public float tempopoison = 3;

    public float tpr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ogcolor = sr.color;
        tpr = tempopoison;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PoisonActive(){
        sr.color = Color.green;
        tpr =- Time.deltaTime;
        if(tpr <= 0){
            sr.color = ogcolor;
            tpr = tempopoison;
        }
    }


}
