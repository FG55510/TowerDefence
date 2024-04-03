using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Supply : MonoBehaviour
{

    public LayerMask enemy;

    void Update(){
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, math.INFINITY, enemy);
        if(hit.collider){
            GameManager.Instance.LoseSuprimentos(1);

            Destroy(gameObject);
        }
    }
    /*
    public void OnTriggerEnter2D (Collider2D collision){
        
        GameManager.Instance.LoseSuprimentos(1);

        Destroy(gameObject);
    }
*/
}
