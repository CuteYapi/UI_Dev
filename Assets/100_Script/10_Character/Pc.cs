using EnumDefine;
using UnityEngine;

public class Pc : MonoBehaviour
{
    public PcAnimation Animation;
    // Skill
    // Status
    // 등등 추가할 예정

    private void Start() // => 나중에는 Start 쓰지 않고 생성하는 코드로 이동할 예정
    {
        Animation.Initialize();
        // 기타 다른 스크립트도 여기에서 초기화
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
