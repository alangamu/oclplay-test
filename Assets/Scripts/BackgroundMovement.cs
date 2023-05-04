using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
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
            _offset = Time.deltaTime * _movementSpeed;
            _material.mainTextureOffset += _offset;
        }
    }
}