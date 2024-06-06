using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;


public class Plot : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Color hoverColor;

    public GameObject towerObject;
    private Color startColor;

    private void Start()
    {
        startColor = _spriteRenderer.color;
       
    }

    private void OnMouseEnter()
    {
        _spriteRenderer.color = hoverColor;
    }

    private void OnMouseExit()
    {
        _spriteRenderer.color = startColor;
    }

    private void OnMouseDown()
    {
        if (towerObject != null)
        {
            //uiManager.ShowUpgradeUI();
            return;
        }

        AttributeTower towerToBuild = BuildManager.main.GetSelectedTower();

        if (towerToBuild.cost > CurrencySystem.Instance.MoralTotal) 
        {
            Debug.Log("You can't afford that");
            return;
        }

        CurrencySystem.Instance.RemoveMoral(towerToBuild.cost);

        towerObject = Instantiate(towerToBuild.prefabTower, transform.position, Quaternion.identity);
    }
}
