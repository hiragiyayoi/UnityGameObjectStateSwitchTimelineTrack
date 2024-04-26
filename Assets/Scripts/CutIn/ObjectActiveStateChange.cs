using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;


[TrackClipType(typeof(CustomClip)), TrackBindingType(typeof(GameObject))]
public class GameObjectStateSwitchTrack : TrackAsset //トラックのInspector設定
{
    public DefaultGameObjectState _DefaultGameObjectState;
    public enum DefaultGameObjectState //stringと同様の扱い
    {
        Active, Inactive
    }
    
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        var playable = ScriptPlayable<TrackBehaviour>.Create(graph, inputCount);//どのPlayableBehaviourで実行させるか指定する．
        var behaviour = playable.GetBehaviour();
        behaviour.GameObjectStateSwitchTrackClass = this;
        
        return playable;
    }
}

public class CustomClip : PlayableAsset, ITimelineClipAsset //クリップのInspector設定
{
    public ClipCaps clipCaps => ClipCaps.None;
    
    public GameObjectState _GameObjectState;
    public enum GameObjectState //stringと同様の扱い
    {
        Active, Inactive
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject go)
    {
        var playable = ScriptPlayable<ClipBehaviour>.Create(graph);//どのPlayableBehaviourで実行させるか指定する．
        var behaviour = playable.GetBehaviour();
        behaviour.CustomClipClass = this;
        
        return playable;
    }
}

public class TrackBehaviour : PlayableBehaviour
{
    private GameObject TrackGameObject;
    private float ClipWeight, _ClipCountlength;
    public GameObjectStateSwitchTrack GameObjectStateSwitchTrackClass;
    
    
    public override void OnGraphStart(Playable playable)
    {
        _ClipCountlength = playable.GetInputCount();
    }
    
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        ClipWeight = 0;
        TrackGameObject = playerData as GameObject;
        
        for (int ClipNum = 0; _ClipCountlength > ClipNum; ClipNum += 1)
        {
            ClipWeight += playable.GetInputWeight(ClipNum);
        }
        
        if (ClipWeight == 0)
        {
            switch (GameObjectStateSwitchTrackClass._DefaultGameObjectState)
            {
                case GameObjectStateSwitchTrack.DefaultGameObjectState.Active:
                  TrackGameObject.SetActive(true);
                  break;
                
                case GameObjectStateSwitchTrack.DefaultGameObjectState.Inactive:
                  TrackGameObject.SetActive(false);
                  break;
                default:
                    break;
            }
        }
    }
}

public class ClipBehaviour : PlayableBehaviour
{
    private GameObject TrackGameObject;
    public CustomClip CustomClipClass;
    
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        TrackGameObject = playerData as GameObject;
        
            switch (CustomClipClass._GameObjectState)
            {
                case CustomClip.GameObjectState.Active:
                    TrackGameObject.SetActive(true);
                    break;
                
                case CustomClip.GameObjectState.Inactive:
                    TrackGameObject.SetActive(false);
                    break;
                default:
                    break;
            }
    }
}


