using UnityEngine;

[CreateAssetMenu]
public class BoolVariable : ScriptableObject
{
    public bool Value => _value;

    [SerializeField]
    private bool _value;

    public void SetValue(bool value)
    {
        _value = value;
    }
}
