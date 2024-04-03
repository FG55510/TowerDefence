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

    public GameObject spawnerEnemy; 
    public Button startWaveButton;

    void Start()
    {
        HideButton();
        waveText.text = "0";
        startWaveButton.onClick.AddListener(StartWave); 
        startWaveButton.interactable = true; 
    }

    void Update()
    {
        HideButton();
        CheckDefeatedEnemies();
    }

    public void StartWave()
    {
        currentWave = currentWave + 1;
        waveInProgress = true;
        startWaveButton.interactable = false;
        spawnerEnemy.GetComponent<SpawnerEnemy>().SpawnEnemy();
        waveText.text = currentWave.ToString();
    }

    public void CheckDefeatedEnemies()
    {
        if (AllEnemiesDefeated())
        {
            waveInProgress = false;
            startWaveButton.interactable = true; 
        }
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

    public void HideButton()
    {
        startWaveButton.interactable = !startWaveButton.interactable;
    }

}
