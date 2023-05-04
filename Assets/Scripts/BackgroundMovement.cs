using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField]
    private LevelVariable _dificultyLevel;
    [SerializeField]
    private Vector2 _movementSpeed;
    [SerializeField]
    private BoolVariable _isGameStartedVariable;
    private Vector2 _offset;
    private Material _material;


    private void Awake()
    {
        _material= GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        if (_isGameStartedVariable.Value)
        {
            _offset = _dificultyLevel.Value * Time.deltaTime * _movementSpeed;
            _material.mainTextureOffset += _offset;
        }
    }
}