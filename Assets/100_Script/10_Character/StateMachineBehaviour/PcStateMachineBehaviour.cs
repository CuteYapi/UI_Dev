using EnumDefine;
using UnityEngine;

public class PcStateMachineBehaviour : StateMachineBehaviour
{
    public Animator Animator;

    private Pc mPc;

    protected Pc Pc
    {
        get
        {
            if(mPc == null)
            {
                mPc = Animator.GetComponentInParent<Pc>();
            }

            return mPc;
        }
    }

    public PcAnimationStatus AnimationStatus = PcAnimationStatus.None;

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateEnter(animator, stateInfo, layerIndex);

        Pc.Animation.currentStatus = AnimationStatus;
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        base.OnStateExit(animator, stateInfo, layerIndex);
    }
}
