using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class MoveStateEvilWizard : State
{
    [SerializeField] private float _speed;

    private static int _move = Animator.StringToHash("Move");

    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Target.transform.position, _speed * Time.deltaTime);
    }

    private void OnEnable()
    {
        _animator.Play(_move);
    }


}
