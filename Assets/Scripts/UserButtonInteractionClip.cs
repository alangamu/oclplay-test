using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class UserButtonInteractionClip : PlayableAsset, ITimelineClipAsset
{
    [SerializeField]
    private UnityEvent _pauseEvent;


    public UserButtonInteractionBehaviour template = new UserButtonInteractionBehaviour();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.None; }
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<UserButtonInteractionBehaviour>.Create(graph, template);

        return playable;
    }

}

