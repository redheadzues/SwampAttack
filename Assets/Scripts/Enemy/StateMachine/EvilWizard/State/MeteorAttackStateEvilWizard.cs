using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CompletedSpellNotifyer))]
public class MeteorAttackStateEvilWizard : State
{
    [SerializeField] private Meteor _meteor;
    [SerializeField] private Transform _meteorSpawnPosition;    

    private Animator _animator;
    private static int _spellCast = Animator.StringToHash("SpellCast");
    private CompletedSpellNotifyer _notifyer;


    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _notifyer = GetComponent<CompletedSpellNotifyer>();
    }

    private void OnEnable()
    {
        MeteorStrike(Target, _meteorSpawnPosition);
    }

    private void MeteorStrike(Player target, Transform spawnPosition)
    {
        var meteor = Instantiate(_meteor, spawnPosition.position, spawnPosition.rotation).GetComponent<Meteor>();
        meteor.Init(Target);

        _animator.Play(_spellCast);
        _notifyer.SpellDoneNotify();
    }

}
