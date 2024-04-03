using System.Collections;
using System.Collections.Generic;
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
      //  if (gameData.playerSuprimentos <= 0)
       // {
            //GameOver
       // }
    }
}
