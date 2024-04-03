using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Followpath : MonoBehaviour
{
    public Transform[] caminho;
    public float speed;

    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(index <= caminho.Length -1){
            transform.position = Vector2.MoveTowards(transform.position, caminho[index].transform.position, speed*Time.deltaTime);
            if(transform.position == caminho[index].transform.position){
                index+=1;
            }
        }
    }
}
