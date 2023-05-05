using UnityEngine;

public class GrabCollider : MonoBehaviour
{
    [SerializeField]
    private AudioSource _audioSource;
    [SerializeField]
    private AudioClip _audioClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);
        _audioSource.clip = _audioClip;
        _audioSource.Play();
    }
}