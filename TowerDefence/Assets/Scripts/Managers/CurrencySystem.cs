using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencySystem : Singleton<CurrencySystem>
{
    [SerializeField] private int moralTotal;

    private string CURRENCY_SAVE_KEY = "MYGAME_CURRENCY";
    public int MoralTotal { get; set; }

    private void Start()
    {
        PlayerPrefs.DeleteKey(CURRENCY_SAVE_KEY);
        LoadMoral();
    }

    private void LoadMoral()
    {
        MoralTotal = PlayerPrefs.GetInt(CURRENCY_SAVE_KEY, moralTotal);
    }

    public void AddMoral(int amount)
    {
        MoralTotal += amount;
        PlayerPrefs.SetInt(CURRENCY_SAVE_KEY, MoralTotal);
        PlayerPrefs.Save();
    }

    public void RemoveMoral(int amount)
    {
        if (MoralTotal >= amount)
        {
            MoralTotal -= amount;
            PlayerPrefs.SetInt(CURRENCY_SAVE_KEY , MoralTotal);
            PlayerPrefs.Save();
        }
    }

    private void AddMoral(EnemyNEO enemy)
    {
        AddMoral(50);
    }


}
