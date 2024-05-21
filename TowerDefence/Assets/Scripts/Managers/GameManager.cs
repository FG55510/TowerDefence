using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public SO_Gamedata gameData;
 //   public static UIManager ui;

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

    public int waveatual = 1;

    public GameStateManager state;

    

    // Start is called before the first frame update
    void Start()
    {
   //     ui = FindAnyObjectByType<UIManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoseSuprimentos(int suprimentos)
    {
        gameData.playerSuprimentos -= suprimentos;
        playerSuprimentos = gameData.playerSuprimentos;
     //   ui.MudarSuplimentos(playerSuprimentos);
      //  if (gameData.playerSuprimentos <= 0)
       // {
            //GameOver
       // }
    }

    public void AddMoral(int moral){
        gameData.playerMoral += moral;
        playermoral = gameData.playerMoral;
       // ui.MudarMoral(playermoral);
    }

   public bool Checkprice(int value){
        if (value <= playermoral){
            return true;
        }
        else{
            return false;
        }
    }

    public void StopHeroes()
    {

    }
}
