using UnityEngine;
using UnityEngine.Playables;

public class ExitCollider : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _timelineToPlay;
    [SerializeField]
    private PlayableDirector _currentTimeline;

    [SerializeField]
    private GameObject _grabButtonGameObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _grabButtonGameObject.SetActive(false);
        _currentTimeline.Stop();
        _timelineToPlay.Play();
    }
}