using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAnim : MonoBehaviour
{
    [SerializeField] private float delayBtwAttack;

    public float AttackDelay { get; set; }

    private Animator _animator;
    private Heroi _tower;
    private EnemyHealth _towerHealth;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _tower = GetComponent<Heroi>();
        _towerHealth = GetComponent<EnemyHealth>();

    }
    public void PlayAttackAnim()
    {
        _animator.SetTrigger("Attack");
    }

    public void PlayDieAnim()
    {
        _animator.SetTrigger("Die");
    }

    public void StopAttackAnim() {
        _animator.SetTrigger("Idle");
    
    }

    private float GetCurrentAnimationLenght()
    {
        float animationLenght = _animator.GetCurrentAnimatorStateInfo(0).length;
        return animationLenght;
    }

    public IEnumerator PlayDead()
    {
        PlayDieAnim();
        yield return new WaitForSeconds(GetCurrentAnimationLenght() + 0.3f);
    }
    private void TowerDead(Heroi tower)
    {
        if (_tower == tower)
        {
            StartCoroutine(PlayDead());
        }
    }


}
