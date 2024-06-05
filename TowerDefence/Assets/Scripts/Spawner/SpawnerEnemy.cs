using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public enum SpawnModes
{
    Fixed,
    Random
}

public class SpawnerEnemy : MonoBehaviour
{
    [Header ("Settings")]
    [SerializeField] private SpawnModes spawnMode = SpawnModes.Fixed;
    [SerializeField] private int enemyCount = 10;
    [SerializeField] private float delayBeetweenWaves = 1f;
    [SerializeField] private int enemyIncperWave = 3;

    [Header("Fixed Delay")]
    [SerializeField] private float delayBeetweenSpawns;

    [Header("Random Delay")]
    [SerializeField] private float minRandomDelay;
    [SerializeField] private float maxRandomDelay;

    private float _spawnTimer;
    private int _enemiesSpawned;
     int _enemiesRemaining;

    private ObjectPooler _pooler;
    private WayPoint _waypoint;
    public WaveManager waveManager;

    public bool final = false;
    

    private void Start()
    {
       
        //Enemyfaltando.quant += enemyCount;
        //_enemiesRemaining = Enemyfaltando.quant;
        _pooler = GetComponent<ObjectPooler>();
        _waypoint = GetComponent<WayPoint>();

        

        waveManager = FindAnyObjectByType<WaveManager>();
    }

    private void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            _spawnTimer = GetSpawnDelay();
            if (_enemiesSpawned < enemyCount)
            {
                _enemiesSpawned++;
                SpawnEnemy();
            }
        }
    }

    public void SpawCommand()
    {
        //StartCoroutine(NextWave());
        //_button.check = false;
    }

    public void SpawnEnemy()
    {
        GameObject newInstance = _pooler.GetInstanceFromPool();
        EnemyNEO enemy = newInstance.GetComponent<EnemyNEO>();
        enemy.Waypoint = _waypoint;
        enemy.ResetEnemy();

        enemy.transform.localPosition = new Vector3 (6.48f, -4.42f, 0);
        newInstance.SetActive(true);
    }

    private float GetSpawnDelay()
    {
        float delay = 0f;
        if (spawnMode == SpawnModes.Fixed)
        {
            delay = delayBeetweenSpawns;
        }
        else
        {
            delay = GetRandomDelay();
        }
        return delay;
    }

    private float GetRandomDelay()
    {
        float randomTimer = Random.Range(minRandomDelay, maxRandomDelay);
        return randomTimer;
    }

    public void IncreaseEnemies(int increase)
    {
        enemyCount += increase; 
    }

    private IEnumerator NextWave ()
    {
        //yield return new WaitForSeconds(delayBeetweenWaves);
        //enemyCount += enemyIncperWave;
        ResetWave();
        yield return null;
    }

    public void ResetWave()
    {
        Enemyfaltando.quant += enemyCount;
        _enemiesRemaining = Enemyfaltando.quant;
        _spawnTimer = 0f;
        _enemiesSpawned = 0;
    }

    private void RecordEnemy()
    {
        Enemyfaltando.quant--;
        _enemiesRemaining = Enemyfaltando.quant;
        if (Enemyfaltando.quant == 0) 
        {
            final = true;
            waveManager.CheckDefeatedEnemies();
            //StartCoroutine(NextWave());
        }
    }

    private void OnEnable()
    {
        EnemyNEO.OnEndReached += RecordEnemy;
        EnemyHealth.OnEnemyKilled += RecordEnemy;
    }

    private void OnDisable()
    {
        EnemyNEO.OnEndReached -= RecordEnemy;
        EnemyHealth.OnEnemyKilled -= RecordEnemy;
    }
}

public static class Enemyfaltando{
    public static int quant;
    public static int falt;
}