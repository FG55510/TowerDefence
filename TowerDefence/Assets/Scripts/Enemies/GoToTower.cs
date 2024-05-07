using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GoToTower : MonoBehaviour
{
    public float speed = 5f;
    public Transform target;
    public EnemystateManager ESM;
    public EstadoEnemy state = EstadoEnemy.Attack;

    private void Start()
    {
        ESM = GetComponent<EnemystateManager>();
    }
    private void Update()
    {
        // Check if the target is assigned
        if (target != null)
        {
            // Calculate the direction to the target
            Vector2 direction = target.position - transform.position;


            // Move towards the target
            transform.Translate(direction * speed * Time.deltaTime);
            
        }
        else
        {
            Debug.LogError("Calma");
        }
        if (transform.position == target.position)
        {
            Reach();
        }

    }
    public void SetTarget(Transform alvo)
    {
        target = alvo;
    }
    public void Reach()
    {
        ESM.EqualizadorEstado(state);
    }
}
