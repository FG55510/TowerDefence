using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public SO_Gamedata gameData;
    
    void Awake () {
        if (!Instance)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public int playerSuprimentos = 3;

    public int playermoral = 400;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoseSuprimentos(int suprimentos)
    {
        gameData.playerSuprimentos -= suprimentos;
        playerSuprimentos = gameData.playerSuprimentos;
      //  if (gameData.playerSuprimentos <= 0)
       // {
            //GameOver
       // }
    }

    public void AddMoral(int moral){
        gameData.playerMoral += moral;
        playermoral = gameData.playerMoral;
    }

   public bool Checkprice(int value){
        if (value <= playermoral){
            return true;
        }
        else{
            return false;
        }
    }
}
