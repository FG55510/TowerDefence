using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMago : MonoBehaviour
{
    public int range;

    public LayerMask Tiles;

    public GameObject[] blocos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)){
             RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position,range,(Vector2) transform.position, 0f, Tiles);
             foreach (RaycastHit2D hit in hits){
                PoisonTile poison = hit.collider.gameObject.GetComponent<PoisonTile>();
                poison.PoisonActive();
            }
        }
    }
}
