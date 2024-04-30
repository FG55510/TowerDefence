using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public enum EstadoEnemy
{
        FollowPath,
        Attack,
        GoTo
}

public enum TipoEnemy
{
    Terrestre,
    Voador
}
public class EnemystateManager : MonoBehaviour
{
    public TipoEnemy tipo;

    public EstadoEnemy estado;
    public EnemyNEO move;

    public EnemyRangeAttack ataque;
    public GoToTower Gtt;

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
        Gtt = GetComponent<GoToTower>();
        estado = EstadoEnemy.FollowPath;
    }

    // Update is called once per frame
    void Update()
    {
        miraativa = Physics2D.OverlapCircle(transform.position,range);
        Detectartorre();
        if (target == null)
        {
            estado = EstadoEnemy.FollowPath;
            Mudarestado(estado);
        }

        else if (tipo == TipoEnemy.Voador && transform.position != target.position)
        {
            estado = EstadoEnemy.GoTo;
            Mudarestado(estado);
        }
        else
        {
            estado = EstadoEnemy.Attack;
            Mudarestado(estado);
        }
    }
    public void EqualizadorEstado(EstadoEnemy state)
    {
        estado = state;
        Mudarestado(estado);
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
    public void Mudarestado(EstadoEnemy estado){
        switch (estado)
        {
        case EstadoEnemy.FollowPath:
            move.enabled = true;
            ataque.enabled = false;
            Gtt.enabled = false;
            break;

        case EstadoEnemy.Attack:
            move.enabled = false;
            ataque.enabled = true;
            Gtt.enabled = false;
            ataque.SetTarget(target);
            break;
        
        
        case EstadoEnemy.GoTo:
            move.enabled = false;
            ataque.enabled = false;
            Gtt.enabled = true;
            Gtt.SetTarget(target);
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
