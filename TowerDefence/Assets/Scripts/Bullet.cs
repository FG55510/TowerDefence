using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float moveSpeed = 5f; // Speed at which the object moves towards the target
    private Transform targetTransform; // The target transform to move towards

    public float dano = 5;

    public LayerMask enemylayer;

    void Update()
    {
        // Check if target transform is assigned
        if (targetTransform != null)
        {
            // Calculate direction towards the target
            Vector2 direction = ((Vector2)targetTransform.position - (Vector2)transform.position).normalized;

            // Calculate the distance to the target
            float distance = Vector2.Distance(transform.position, targetTransform.position);

            // If not reached the target yet, move towards it
            if (distance > 0.1f)
            {
                // Move the object towards the target
                transform.Translate(direction * moveSpeed * Time.deltaTime);
            }
            else{
                RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.zero, math.INFINITY, enemylayer);
                EnemyHealth enemy = hit.collider.GetComponent<EnemyHealth>();
                enemy.DealDamage(dano);
                Destroy(gameObject);
            }
        }
        
    }

   /* private void OnTriggerEnter2D(Collider2D collision){
        EnemyHealth enemy = collision.GetComponent<EnemyHealth>();
        enemy.DealDamage(dano);
        Destroy(gameObject);
    }*/

    // Method to set the target transform
    public void SetTarget(Transform target)
    {
        targetTransform = target;
    }
}
