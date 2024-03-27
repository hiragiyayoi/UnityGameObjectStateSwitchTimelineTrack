using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.Playables;

namespace Fight.Runtime.Timeline.AttackGenertation
{
    [TrackClipType(typeof(AttackGenerationClip))]
    [TrackBindingType(typeof(SphereCollider))]
    public class AttackGenerationTrack : TrackAsset
    {
        public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
        {
            var playable = ScriptPlayable<AttackGenerationTrackBehaviour>.Create(graph, inputCount);//どのPlayableBehaviourで実行させるか指定する．
            var behaviour = playable.GetBehaviour();
            behaviour.AttackGenerationTrackClass = this;

            return playable;
        }
    }
}

