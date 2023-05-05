using UnityEngine;

public class TreasureMovement : MonoBehaviour
{
    [SerializeField]
    private LevelVariable _dificultyLevel;
    [SerializeField]
    private float _movementSpeed;

    private bool _canMove = false;

    public void BeginMovement()
    {
        _canMove = true;
    }

    private void Update()
    {
        if (_canMove)
        {
            transform.Translate((1 + _dificultyLevel.Value * .3f) * _movementSpeed * Time.deltaTime * Vector3.left);
        }
    }
}