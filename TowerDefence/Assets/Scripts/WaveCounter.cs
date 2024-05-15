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
    public int enecounter = 0;

    public SpawnerEnemy Spawner1;
    public SpawnerEnemy Spawner2;
    // Start is called before the first frame update
    void Start()
    {
    }
}
