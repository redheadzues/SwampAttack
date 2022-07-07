using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CompletedSpellNotifyer))]
public class MoveTransitionEvilWizard : Transition
{
    private CompletedSpellNotifyer _notifyer;

    private void Awake()
    {
        _notifyer = GetComponent<CompletedSpellNotifyer>();

    }
    private void OnEnable()
    {
        _notifyer.SpellDone += NeedTransitChanger;
    }

    private void OnDisable()
    {
        _notifyer.SpellDone -= NeedTransitChanger;
    }

    private void NeedTransitChanger()
    {
        NeedTransit = true;
    }
}
