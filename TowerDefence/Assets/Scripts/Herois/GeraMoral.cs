using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraMoral : MonoBehaviour
{
    public int moralgerada = 100;

    public float Tempoparagerar = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Tempoparagerar -= Time.deltaTime;
        if(Tempoparagerar <= 0){
            AumentaMoral();
            Tempoparagerar = 5;
        }
    }

    public void AumentaMoral(){
        GameManager.Instance.AddMoral(moralgerada);  
    }
}
