using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompraDeHeroi : MonoBehaviour
{
    public int precobardo = 100;

    public int precomago = 300;

    public int precofazendeira = 100;

    public bool check;

    public bool Checkprecobardo(){
       check = GameManager.Instance.Checkprice(precobardo);

       if(check == true){
        GameManager.Instance.AddMoral(-precobardo);
        return true;
       }
       else{
        return false;
       }


    }

    public bool Checkprecofazendeira(){
       check = GameManager.Instance.Checkprice(precofazendeira);

       if(check){
        GameManager.Instance.AddMoral(-precofazendeira);
        return true;
       }
       else{
        return false;
       }
    }

    public bool Checkprecomago(){
       check = GameManager.Instance.Checkprice(precomago);

       if(check){
        GameManager.Instance.AddMoral(-precomago);
        return true;
       }
       else{
        return false;
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
