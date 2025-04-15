using EnumDefine;
using System.Collections.Generic;
using UnityEngine;

public class PcAnimation : MonoBehaviour
{
    public Animator Animator { get; set; }

    public PcAnimationStatus currentStatus;

    private Dictionary<PcAnimationStatus, string> mAnimationStatusNameDictionary;

    public void Initialize()
    {
        Animator = transform.GetComponent<Animator>();
        SetAnimationDictionary();
        SetStateMachineBehaviour();
    }

    public void PlayAnimation(PcAnimationStatus animationStatus)
    {
        if (HasHigherPriority(animationStatus, currentStatus) == false)
        {
            return;
        }

        ExecuteAnimation(animationStatus);
    }

    private void SetStateMachineBehaviour()
    {
        PcStateMachineBehaviour[] behaviours = Animator.GetBehaviours<PcStateMachineBehaviour>();
        foreach (PcStateMachineBehaviour behavior in behaviours)
        {
            behavior.Animator = Animator;
        }
    }

    private void SetAnimationDictionary()
    {
        mAnimationStatusNameDictionary = new Dictionary<PcAnimationStatus, string>
        {
            { PcAnimationStatus.Idle, "Idle"},
            { PcAnimationStatus.Run, "Run" },

            { PcAnimationStatus.Jump0, "Jump.0" },
            { PcAnimationStatus.Jump1, "Jump.1" },
            { PcAnimationStatus.Jump2, "Jump.2" },
            { PcAnimationStatus.Jump3, "Jump.3" },
        };
    }

    private bool HasHigherPriority(PcAnimationStatus newStatus, PcAnimationStatus currentStatus)
    {
        return (int)newStatus / 100 >= (int)currentStatus / 100;
    }


    private void ExecuteAnimation(PcAnimationStatus animationStatus)
    {
        if(mAnimationStatusNameDictionary.TryGetValue(animationStatus, out string animationName) == false)
        {
            Log.Error("해당 애니메이션이 존재하지 않습니다");
        }

        currentStatus = animationStatus;
        Animator.Play(animationName);
    }

    
}
