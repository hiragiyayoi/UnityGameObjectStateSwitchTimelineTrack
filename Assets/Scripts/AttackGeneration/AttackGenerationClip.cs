using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UIElements;
using UnityEditor;

namespace Fight.Runtime.Timeline.AttackGenertation
{
    [Serializable]
    public class AttackGenerationClip : PlayableAsset, ITimelineClipAsset
    {
        public ClipCaps clipCaps => ClipCaps.None;

        [SerializeField]
        private AttackGenerationClipBehaviour AttackGenerationClipBehaviourClass = new();

        public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
        {
            var playable = ScriptPlayable<AttackGenerationClipBehaviour>.Create(graph, AttackGenerationClipBehaviourClass);

            return playable;
        }
    }

}

