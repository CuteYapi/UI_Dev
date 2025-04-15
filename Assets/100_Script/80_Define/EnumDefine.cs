using UnityEngine;

namespace EnumDefine
{
    // Ư�� �Ӽ�
    public enum AttackType
    {        // ���� Ÿ��
        None = -1,

        EXPLOSIVE,           // ������
        PENETRATION,         // ������
        MYSTIC               // �ź���
    };

    public enum ArmorType
    {         // ��� Ÿ��
        None = -1,

        LIGHT_ARMOR,         // ���尩
        HEAVY_ARMOR,         // ���尩
        SPECIAL_ARMOR        // Ư���尩
    };

    public enum CombatRole
    {        // ���� ����
        None = -1,

        STRIKER,             // ��Ʈ����Ŀ(������)
        SPECIAL              // �����(������)
    };

    public enum AttackRange
    {       // ���� ����
        None = -1,

        FRONT,               // ����
        REAR                 // �Ĺ�
    };

    public enum CombatPosition
    {    // ���� ��ġ
        None = -1,

        FRONT_LINE,          // ����
        MIDDLE_LINE,         // �߿�
        BACK_LINE            // �Ŀ�
    };


    public enum GradeType
    {
        None = -1,

        Common = 0,
        Rare = 1,
        Legendary = 2,
        Epic = 3,

        MAX,
    }

    public enum AbilityReason
    {
        None = -1,

        Level = 0,
        
        Equip1 = 1,
        Equip2 = 2,
        Equip3 = 3,
        Equip4 = 4,

        MAX,
    }

    public enum AbilityType
    {
        None = -1,

        MaxHP = 0,
        AttackPower = 1,
        Defense = 2,
        HealAmount = 3,

        MAX,
    }

    public enum ItemGrade
    {
        None = -1,

        Common,

        Rare,

        Epic, // �����

        Legendary, // ���� 

        Max,
    }

    public enum ConsumeType
    {
        None = -1,

        Unusable,

        Select,
        Random,

        Max,
    }

    public enum EuipTier
    {
        None = -1,

        Tier0, 
        Tier1, 
        Tier2, 
        Tier3, 
        Tier4, 
        Tier5, 
        Tier6, 
        Tier7, 
        Tier8, 
        Tier9,

        Max,
    }

    public enum PcAnimationStatus
    {
        None = -1,

        Idle = 0,
        Run = 1,

        Jump0 = 100,
        Jump1 = 101,
        Jump2 = 102,
        Jump3 = 103,
        JumpEnd = 104,
    }
}
