using System;
using UnityEngine;
using UnityEngine.Playables;

namespace Fight.Runtime.Timeline.AttackGenertation
{
    [SerializeField]
    public class AttackGenerationTrackBehaviour : PlayableBehaviour
    {
        public AttackGenerationTrack AttackGenerationTrackClass;

        private BoxCollider AttackGameObject;
        private CapsuleCollider AttackCollider;
        private float ClipWeight, _ClipCountlength;

        public override void ProcessFrame(Playable playable, FrameData info, object playerData)
        {        
            AttackGameObject = playerData as BoxCollider;
            ClipWeight = 0;

            for (int ClipNum = 0; _ClipCountlength > ClipNum; ClipNum += 1)
            {
                ClipWeight += playable.GetInputWeight(ClipNum);
            }

            if(ClipWeight == 0)
            {
                AttackCollider.enabled = false;
            }
            else
            {
                AttackCollider.enabled = true;
            }
        }
    }


}

