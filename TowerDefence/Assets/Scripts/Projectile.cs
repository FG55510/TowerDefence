using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Transform target;

    public float speed = 70f;

    public void SetTarget (Transform alvo){
        target = alvo;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (target = null){
            Destroy(gameObject);
            return;
        }

        Vector2 direction = (target.position - transform.position);
        float distancett = speed * Time.deltaTime;
    }
}
