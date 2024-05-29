using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveCounter : MonoBehaviour
{
    public static WaveCounter Instance;
    void Awake()
    {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public int waveatual = 0;
    public int eneplus = 1;

    public GameObject[] Spawners;

    
    // Start is called before the first frame update
    void Start()
    {
        Spawners[0].SetActive(true);
        for (int i = 1; i < Spawners.Length; i++)
        {
            Spawners[i].SetActive(false);
        }
    }

    public void MaisSpawners()
    {
        waveatual ++;
        Spawners[waveatual].SetActive(true);
        foreach (GameObject obj in Spawners)
        {
            SpawnerEnemy se = obj.GetComponent<SpawnerEnemy>();
            se.IncreaseEnemies(eneplus);
        }
    }
}
