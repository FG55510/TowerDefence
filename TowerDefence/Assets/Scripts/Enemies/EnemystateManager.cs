using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public enum Estado
{
        FollowPath,
        Attack
}
public class EnemystateManager : MonoBehaviour
{

    public Estado estado;
    public EnemyNEO move;

    public EnemyRangeAttack ataque;

    public int indexpause;


    public Transform target;
    public float range = 1.5f;
    public LayerMask Torres;

    public bool miraativa = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        move =  GetComponent<EnemyNEO>();
        ataque = GetComponent<EnemyRangeAttack>();
        estado = Estado.FollowPath;
    }

    // Update is called once per frame
    void Update()
    {
        miraativa = Physics2D.OverlapCircle(transform.position,range);
        Detectartorre();
        if(target != null){
            estado = Estado.Attack;
            Mudarestado(estado);
        }
        else {
            estado = Estado.FollowPath;
            Mudarestado(estado);
        }
    }

    public void Detectartorre(){
        RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position,range,(Vector2) transform.position, 0f, Torres);
        if(hits.Length > 0){
            target = hits[0].transform;
        }
        else{
            target = null;
        }
    }
    public void Mudarestado(Estado estado){
        switch (estado)
    {
        case Estado.FollowPath:
        move.enabled = true;
        ataque.enabled = false;
        break;
        case Estado.Attack:
        move.enabled = false;
        ataque.enabled = true;
        ataque.SetTarget(target);
        break;
    }
    }

    private void OnDrawGizmos()
    {
        

        if(target!= null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position,range);
        }
        else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(transform.position,range);
        }
    }
}
    
    
    /*
        */
