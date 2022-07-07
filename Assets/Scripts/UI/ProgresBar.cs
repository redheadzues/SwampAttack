using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgresBar : Bar
{
    [SerializeField] private Spawner _spawner;

    private void OnEnable()
    {
        _spawner.EnemySpawnChanged += OnValueChanged;
        Slider.value = 0;
    }

    private void OnDisable()
    {
        _spawner.EnemySpawnChanged -= OnValueChanged;
    }
}
