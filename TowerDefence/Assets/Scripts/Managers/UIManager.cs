using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtMoral;
    public TMP_Text txtSuplimentos;
    public TMP_Text txtEnd;
    // Start is called before the first frame update
    void Start()
    {
        txtMoral.text = "500";
        txtSuplimentos.text = "3";
    }

    public void MudarSuplimentos(int value)
    {
        txtSuplimentos.text =  value.ToString();
    }

    public void MudarMoral(int value)
    {
        txtMoral.text = value.ToString();
    }

    public void GameOver()
    {
        txtEnd.text = "GameOver";
    }
}
