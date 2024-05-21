using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeraMoral : MonoBehaviour
{
    public int moralgerada = 100;

    public float Tempoparagerar = 5f;

    public float tpg;


    // Start is called before the first frame update
    void Start()
    {
        tpg = Tempoparagerar;
    }

    // Update is called once per frame
    void Update()
    {
        Delayparagerar();
    }

    public void AumentaMoral(){
        GameManager.Instance.AddMoral(moralgerada);  
    }

    public void Delayparagerar()
    {
        tpg -= Time.deltaTime;
        if (tpg <= 0)
        {
            AumentaMoral();
            tpg = Tempoparagerar;
        }
    }

    public void ChangeTime(float minustime)
    {
        Tempoparagerar -= minustime;
        if (tpg > Tempoparagerar)
        {
            tpg = Tempoparagerar ;
        }
    }
    
    public void ChangeGD(int somamoral)
    {
        moralgerada += somamoral;
    }
}
