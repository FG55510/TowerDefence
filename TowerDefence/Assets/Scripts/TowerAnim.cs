using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAnim : MonoBehaviour
{
    [SerializeField] private float delayBtwAttack;

    public float AttackDelay { get; set; }

    private Animator _animator;
    private Tower _tower;
    private TowerHealth _towerHealth;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _tower = GetComponent<Tower>();
        _towerHealth = GetComponent<TowerHealth>();
        AttackDelay = delayBtwAttack;
    }
    private void PlayAttackAnim()
    {
        _animator.SetTrigger("TowerAttack");
    }

    private void PlayDieAnim()
    {
        _animator.SetTrigger("TowerDie");
    }

    private float GetCurrentAnimationLenght()
    {
        float animationLenght = _animator.GetCurrentAnimatorStateInfo(0).length;
        return animationLenght;
    }

    private IEnumerator PlayDead()
    {
        PlayDieAnim();
        yield return new WaitForSeconds(GetCurrentAnimationLenght() + 0.3f);
    }
    private void TowerDead(Tower tower)
    {
        if (_tower == tower)
        {
            StartCoroutine(PlayDead());
        }
    }

    private void OnEnable()
    {
        TowerHealth.OnTowerKilled += TowerDead;
    }

    private void OnDisable()
    {
        TowerHealth.OnTowerKilled -= TowerDead;
    }
}
