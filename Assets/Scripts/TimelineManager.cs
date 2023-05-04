using UnityEngine;
using UnityEngine.Playables;

public class TimelineManager : MonoBehaviour
{
    [SerializeField]
    private PlayableDirector _mainDirector;
    private PlayableDirector _currentDirector;

    public void PauseTimeline(PlayableDirector currentDirector)
    {
        _mainDirector.Pause();
        _currentDirector = currentDirector;
        _currentDirector.Pause();
    }

    public void ResumeTimeline()
    {
        _currentDirector.Resume();
        _mainDirector.Resume();
    }
}