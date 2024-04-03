using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    public GameObject[] enemies;

    int index = 0;

    private void Start()
    {
        InvokeRepeating("Spawenemy", 0, 1);
    }

    void Spawenemy()
    {
        GameObject tmp = Instantiate(enemies[index], transform.position, Quaternion.identity);

        index++;
        if (index >= 3)
        {
            index = 0;
        }

    }
}
