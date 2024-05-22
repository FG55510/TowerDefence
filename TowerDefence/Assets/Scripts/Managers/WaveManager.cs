using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WaveManager : MonoBehaviour
{
    public int currentWave = 0;
    public TMP_Text waveText;
    private bool waveInProgress = false;

    public WaveCounter waveCounter;

    public GameObject spawnerEnemy;
    public SpawnerButton button;

    private void Start()
    {
        waveText.text = currentWave.ToString();
    }


    public void StartWave()
    {
        waveCounter.MaisSpawners();
        currentWave = currentWave + 1;
        waveInProgress = true;
        button.check = false;
        spawnerEnemy.GetComponent<SpawnerEnemy>().SpawnEnemy();
        waveText.text = currentWave.ToString();
    }

    public void CheckDefeatedEnemies()
    {
        button.check = true;

    }

    bool AllEnemiesDefeated()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy"); //
        foreach (GameObject enemy in enemies)
        {
            if (!enemy.CompareTag("Enemy"))
            {
                return false;
            }
        }
        return true; 
    }


}
