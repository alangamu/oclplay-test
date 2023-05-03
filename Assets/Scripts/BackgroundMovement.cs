using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    [SerializeField]
    private IntVariable _dificultyLevel;
    [SerializeField]
    private Vector2 _movementSpeed;

    private Vector2 _offset;
    private Material _material;

    private void Awake()
    {
        _material= GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        _offset = _dificultyLevel.Value * Time.deltaTime * _movementSpeed;
        _material.mainTextureOffset += _offset;
    }
}