using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public TMP_Text txtMoral;
    public TMP_Text txtSuplimentos;
    // Start is called before the first frame update
    void Start()
    {
        txtMoral.text = "Moral: 700";
        txtSuplimentos.text = "Suplimentos: 3";
    }

    public void MudarSuplimentos(int value)
    {
        txtSuplimentos.text = "Suplimentos:" + value;
    }

    public void MudarMoral(int value)
    {
        txtMoral.text = "Moral:" + value;
    }
}
