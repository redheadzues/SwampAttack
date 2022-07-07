using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackStateEvilWizard : State
{
    [SerializeField] private float _delay;
    [SerializeField] private int _damage;

    private Animator _animator;
    private float _timeAfterLastAttack;
    private static int _attack = Animator.StringToHash("Attack");

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(_timeAfterLastAttack >= _delay)
        {
            Attack(Target);
            _timeAfterLastAttack = 0;
        }

        _timeAfterLastAttack += Time.deltaTime;
    }

    private void Attack(Player target)
    {
        target.ApplyDamage(_damage);
        _animator.Play(_attack);
    }
}
