using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRangeAttack : MonoBehaviour
{

    public Transform target;

    public Transform arma;
    public float firetime;

    public float sps;

    public GameObject GoBullet;

    // Start is called before the first frame update


    public void SetTarget (Transform alvo){
        target = alvo;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
}
