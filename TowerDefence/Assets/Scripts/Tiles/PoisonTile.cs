using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PoisonTile : MonoBehaviour
{
    public Color ogcolor;
    public SpriteRenderer sr;

    public StateTile state;

    public float tempopoison = 3f;

    public float tpr;

    public string Enemytag = "Enemy";
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ogcolor = sr.color;
        tpr = tempopoison;

        state = GetComponent<StateTile>();
    }

    // Update is called once per frame
    void Update()
    {
        PoisonActive();

    }

    public void PoisonActive(){
        sr.color = Color.green;
        tpr -= Time.deltaTime;
        if(tpr <= 0){
            sr.color = ogcolor;
            state.MudarEstado(EstadoTile.Normal);
            tpr = tempopoison;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   Debug.LogError("Colidiu");
        if(collision.CompareTag(tag))
        {
            
            EnemyHealth eh = collision.GetComponent<EnemyHealth>();
            eh.DealDamage(1);

        }
        
    }


}