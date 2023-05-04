using UnityEngine;

public class TreasureDisabler : MonoBehaviour
{
    [SerializeField]
    private int _index;
    [SerializeField]
    private LevelVariable _levelVariable;

    private void OnEnable()
    {
        if (_levelVariable.Value + 3 <= _index)
        {
            gameObject.SetActive(false);
        }
    }
}