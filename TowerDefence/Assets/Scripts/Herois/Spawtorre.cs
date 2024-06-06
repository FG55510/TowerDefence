using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public enum TorreSpawn
{
    Fazendeira,
    Mago,
    Bardo
}

public class Spawtorre : MonoBehaviour
{
    public TorreSpawn _torreSpawn;

    public bool modoheroi;

    public bool modobardo;

    public GameObject torre;
    public GameObject heroi;

    public GameObject bardo;

    Camera cam;
    public LayerMask spawheroi;
    public LayerMask spawtorre;

    public CompraDeHeroi compra;

    public bool check;

    // Start is called before the first frame update
    void Start()
    {
        compra = GetComponent<CompraDeHeroi>();
        cam = Camera.main;
        modoheroi = false;
        _torreSpawn = TorreSpawn.Mago;
        /*co = GetComponent<Collider2D>();
        largura = co.bounds.size.x/2;
        altura = co.bounds.size.y/2;*/
    }

    // Update is called once per frame

    void Update()
    {

        switch (_torreSpawn)
        {
            case (TorreSpawn.Fazendeira):

                if (Input.GetMouseButtonDown(0))
                {

                    RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, math.INFINITY, spawheroi);

                    if (hit.collider)
                    {
                        check = compra.Checkprecofazendeira();
                        if (check)
                        {
                            hit.collider.gameObject.layer = LayerMask.NameToLayer("Ocupado");
                            Instantiate(heroi, hit.collider.gameObject.transform.position, Quaternion.identity);

                        }

                    }

                }
                break;

            case (TorreSpawn.Bardo):
                {
                    if (Input.GetMouseButtonDown(0))
                    {

                        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, math.INFINITY, spawtorre);

                        if (hit.collider)
                        {
                            check = compra.Checkprecobardo();
                            if (check)
                            {
                                hit.collider.gameObject.layer = LayerMask.NameToLayer("Ocupado");
                                Instantiate(bardo, hit.collider.gameObject.transform.position, Quaternion.identity);
                            }

                        }
                    }
                }
                    break;

                    case (TorreSpawn.Mago):
                        {
                            if (Input.GetMouseButtonDown(0))
                            {

                                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero, math.INFINITY, spawtorre);

                                if (hit.collider)
                                {
                                    check = compra.Checkprecomago();
                                    if (check)
                                    {
                                        hit.collider.gameObject.layer = LayerMask.NameToLayer("Ocupado");
                                        Instantiate(torre, hit.collider.gameObject.transform.position, Quaternion.identity);
                                    }
                                    else
                                    {
                                        Debug.Log("Não deu");
                                    }
                                    //  Debug.Log ("Target Position: " + hit.collider.gameObject.transform.position);

                                }
                            }
                    break;
                    }
        }
    }

    public void ChangeToFazendeira()
    {
        _torreSpawn = TorreSpawn.Fazendeira;
    }

    public void ChangeToBardo()
    {
        _torreSpawn = TorreSpawn.Bardo;
    }

    public void ChangeToMago()
    {
        _torreSpawn = TorreSpawn.Mago;
    }
}

