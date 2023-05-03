using UnityEngine;

[CreateAssetMenu]
public class IntVariable : ScriptableObject
{
    public int Value => _value;

    [SerializeField]
    [Range(1, 3)]
    private int _value;

    public void SetValue(int value)
    {
        _value = value;
    }
}