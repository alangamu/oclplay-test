using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class UserButtonInteractionBehaviour : PlayableBehaviour
{
    public UnityEvent PauseEvent;

    private PlayableDirector director;
    private bool clipPlayed = false;
    private bool pauseScheduled = false;

    public override void OnPlayableCreate(Playable playable)
    {
        director = (playable.GetGraph().GetResolver() as PlayableDirector);
    }

    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        if (!clipPlayed
            && info.weight > 0f)
        {
            if (Application.isPlaying)
            {
                pauseScheduled = true;
            }

            clipPlayed = true;
        }
    }

    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        if (pauseScheduled)
        {
            pauseScheduled = false;
            //pausa el juego
            //GameManager.Instance.PauseTimeline(director);
            Debug.Log("pausa");
            PauseEvent.Invoke();
            //director.Pause();
        }
        //else
        //{
        //    UIManager.Instance.ToggleDialoguePanel(false);
        //}

        clipPlayed = false;
    }
}