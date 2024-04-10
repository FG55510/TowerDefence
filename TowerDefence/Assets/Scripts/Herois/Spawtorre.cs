using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class Spawtorre : MonoBehaviour
{
    public bool modoheroi;

    public bool modobardo;
    public GameObject torre;
    public GameObject heroi;

    public GameObject bardo;
   /* Vector3 mousepos;

    Collider2D co;
    public bool temtorre = false;

    

    public GameObject tile;

    float largura;

    float altura;*/
    Camera cam;
    public LayerMask spawheroi;
    public LayerMask spawtorre; 

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        modoheroi = false;
        /*co = GetComponent<Collider2D>();
        largura = co.bounds.size.x/2;
        altura = co.bounds.size.y/2;*/
    }

    // Update is called once per frame

    void Update(){
        if(Input.GetKeyDown(KeyCode.M)){
            modobardo = !modobardo;
        }
        if(modobardo){
            if (Input.GetMouseButtonDown(0)){

                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, math.INFINITY, spawtorre);

                if(hit.collider)
                {
                    Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
                    hit.collider.gameObject.layer = LayerMask.NameToLayer("Ocupado");
                    Instantiate(bardo, hit.collider.gameObject.transform.position, Quaternion.identity, hit.collider.gameObject.transform);
                }
            }
        }
        else {
        if (modoheroi){
            if (Input.GetMouseButtonDown(0)){

                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, math.INFINITY, spawheroi);

                if(hit.collider)
                {
                    Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
                    hit.collider.gameObject.layer = LayerMask.NameToLayer("Ocupado");
                    Instantiate(heroi, hit.collider.gameObject.transform.position, Quaternion.identity, hit.collider.gameObject.transform);
                }
            }
        }
        if(!modoheroi){
            if (Input.GetMouseButtonDown(0)){

                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, math.INFINITY, spawtorre);

                if(hit.collider)
                {
                    Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);
                    hit.collider.gameObject.layer = LayerMask.NameToLayer("Ocupado");
                    Instantiate(torre, hit.collider.gameObject.transform.position, Quaternion.identity, hit.collider.gameObject.transform);
                }
            }
        }
        }
        
        if(Input.GetKeyDown(KeyCode.Q)){
            modoheroi = !modoheroi;
        }
        
        
        }
       /* if (temtorre == false){
            if(Input.GetKeyDown(KeyCode.Mouse0)){
                mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if(mousepos.x <= largura && mousepos.x >= -largura && mousepos.y <= altura && mousepos.y >= -altura){
                    Instantiate(torre, transform.position, Quaternion.identity, tile.transform);
                    temtorre = true;
                }

            }
        }*/

        
}

