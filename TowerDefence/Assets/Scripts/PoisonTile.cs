using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoisonTile : MonoBehaviour
{
    public Color ogcolor;
    public SpriteRenderer sr;

    public float tempopoison = 3f;

    public float tpr;

    public string tag = "Enemy";
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ogcolor = sr.color;
        tpr = tempopoison;
    }

    // Update is called once per frame
    void Update()
    {
        PoisonActive();
        tpr -= Time.deltaTime;
        if (tpr <= 0)
        {
            sr.color = ogcolor;
        }
    }

    public void PoisonActive(){
        sr.color = Color.green;
        tpr -= Time.deltaTime;
        if(tpr <= 0){
            sr.color = ogcolor;
            tpr = tempopoison;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(tag))
        {
            EnemyHealth eh = collision.GetComponent<EnemyHealth>();
            eh.DealDamage(1);

        }
        
    }


}
