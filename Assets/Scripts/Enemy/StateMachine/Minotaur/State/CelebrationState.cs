using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CelebrationState : State
{
    private Animator _animator;
    private static int _celebration = Animator.StringToHash("Celebration");

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        _animator.Play(_celebration);
    }

    private void OnDisable()
    {
        _animator.StopPlayback();
    }
}
