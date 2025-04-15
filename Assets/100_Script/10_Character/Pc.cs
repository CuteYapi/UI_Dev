using EnumDefine;
using UnityEngine;

public class Pc : MonoBehaviour
{
    public PcAnimation Animation;
    // Skill
    // Status
    // ��� �߰��� ����

    private void Start() // => ���߿��� Start ���� �ʰ� �����ϴ� �ڵ�� �̵��� ����
    {
        Animation.Initialize();
        // ��Ÿ �ٸ� ��ũ��Ʈ�� ���⿡�� �ʱ�ȭ
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1) == true)
        {
            Animation.PlayAnimation(PcAnimationStatus.Idle);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) == true)
        {
            Animation.PlayAnimation(PcAnimationStatus.Run);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) == true)
        {
            int randomJumpSeed = Random.Range((int)PcAnimationStatus.Jump0, (int)PcAnimationStatus.JumpEnd);
            Animation.PlayAnimation((PcAnimationStatus)randomJumpSeed);
        }

    }
}
