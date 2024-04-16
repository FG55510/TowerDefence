using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroi : MonoBehaviour
{   
    public float rotationspeed;

    
    public bool miraativa = false;
    public GameObject targetEnemy;
    public int dano;
    public int vida;
    public Transform target;
    public float range = 2.5f;
    public LayerMask Inimigos;

    public string tagEnemy;
    
    
    public GameObject GoBullet;

    public Transform arma;

    public float firetime;

    public float sps;

    // Start is called before the first frame update
    void Start()
    {
        Inimigos = LayerMask.NameToLayer("Inimigos");
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    void UpdateTarget ()
	{
		/*RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position,range,(Vector2) transform.position, 0f, Inimigos);
        if(hits.Length > 0){
            target = hits[0].transform;
        }
        else{
            target = null;
        }
        */
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(tagEnemy);
		float shortestDistance = Mathf.Infinity;
		GameObject nearestEnemy = null;
		foreach (GameObject enemy in enemies)
		{
			float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
			if (distanceToEnemy < shortestDistance)
			{
				shortestDistance = distanceToEnemy;
				nearestEnemy = enemy;
			}
		}

		if (nearestEnemy != null && shortestDistance <= range)
		{
			target = nearestEnemy.transform;
		} else
		{
			target = null;
		}
	}
    /*void LockOnTarget ()
	{
        float angle = Mathf.Atan2(target.position.y - transform.position.y, target.position.x - transform.position.x) 
        * Mathf.Rad2Deg - 90f;

        Quaternion targetrotation = Quaternion.Euler(new Vector3(0f,0f, angle));
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetrotation, rotationspeed * Time.deltaTime);
		
	}*/

    // Update is called once per frame
    void Update()
    {
        miraativa = Physics2D.OverlapCircle(transform.position,range);

        if (target == null)
		{
            return;
        }
        else{
            //LockOnTarget();
            firetime += Time.deltaTime;

            if(firetime >= 1f/ sps){
                Shoot();
                firetime = 0f;
            }
        }
    }

    public void Shoot(){
       GameObject bala = Instantiate(GoBullet, transform.position, Quaternion.identity);
       Bullet tiro = bala.GetComponent<Bullet>();

       if(tiro != null){
        tiro.SetTarget(target);
       }
       else
       {
        Debug.LogError("MoveTowardsTransform component not found on the instantiated object.");
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
