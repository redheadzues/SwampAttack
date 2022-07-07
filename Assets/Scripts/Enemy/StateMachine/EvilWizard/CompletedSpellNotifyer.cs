using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CompletedSpellNotifyer : MonoBehaviour
{
    private int _timeToWaitAnimation = 1;
    private Coroutine _coroutine;

    public event UnityAction SpellDone;

    public void SpellDoneNotify()
    {
        if (_coroutine != null)
            StopCoroutine(_coroutine);

        _coroutine = StartCoroutine(WaitAndNotify());
    }

    private IEnumerator WaitAndNotify()
    {
        var waitingTime = new WaitForSeconds(_timeToWaitAnimation);
        yield return waitingTime;
        SpellDone?.Invoke();
    }
}
