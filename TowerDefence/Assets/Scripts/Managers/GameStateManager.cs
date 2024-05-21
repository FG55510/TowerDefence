using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameState
{
    Paused,
    BetweenWaves,
    Wave,
    GameOver
}
public class GameStateManager : MonoBehaviour
{
    public GameState State;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeState(GameState estado)
    {
        ResetState();

         State = estado;
    }
    public void ResetState() { 
        
    }
}
