using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillBardo1 : MonoBehaviour
{
    public GeraMoral Geramoral;

    public float diminuirdelay = 0.5f;

    public int aumentarquanmoral = 10;
        
    // Start is called before the first frame update
    void Start()
    {
        Geramoral = GetComponent<GeraMoral>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            UpgradeDelay();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            UpgradeQuant();
        }
    }

    public void UpgradeDelay()
    {
        Geramoral.ChangeTime(diminuirdelay);
    }

    public void UpgradeQuant()
    {
        Geramoral.ChangeGD(aumentarquanmoral);
    }
}
