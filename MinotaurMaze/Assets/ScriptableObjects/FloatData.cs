using UnityEngine;
using UnityEngine.Events;

[ExecuteInEditMode]
[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;
    public UnityEvent updateValueEvent;

    public void SetValue (float num)
    {
        value = num;
    }

    public void UpdateValue (float num)
    {
        value += num;
        updateValueEvent.Invoke();
    }
}
