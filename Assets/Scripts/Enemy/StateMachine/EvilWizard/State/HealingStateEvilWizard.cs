using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CompletedSpellNotifyer))]
public class HealingStateEvilWizard : State
{
    [SerializeField] private int _healingCount;

    private Animator _animator;
    private CompletedSpellNotifyer _notifyer;
    private static int _spellCast = Animator.StringToHash("SpellCast");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _notifyer = GetComponent<CompletedSpellNotifyer>();
    }

    private void OnEnable()
    {
        CureAllies();
    }

    private void CureAllies()
    {
        var foundEnemies =  FindObjectsOfType<Enemy>();

        foreach(Enemy enemy in foundEnemies)
        {
            enemy.TakeHeal(_healingCount);
        }

        _animator.Play(_spellCast);
        _notifyer.SpellDoneNotify();
    }
}
