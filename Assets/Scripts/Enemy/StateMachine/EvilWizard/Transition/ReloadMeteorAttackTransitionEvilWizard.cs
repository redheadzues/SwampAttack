using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadMeteorAttackTransitionEvilWizard : Transition

{
    [SerializeField] private float _reloadTime;

    private float _currentTime;
    private void Update()
    {
        _currentTime += Time.deltaTime;

        if( _currentTime >= _reloadTime )
        {
            NeedTransit = true;
            _currentTime = 0;
        }
    }
}
