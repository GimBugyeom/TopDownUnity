using UnityEngine;

public class NPC : MonoBehaviour
{
    NPC_Talk npcTalk;
    //NPC_Talk ��ȣ�ۿ� **
    //NPC_Move �����̱�
    //NPC_Battle ��Ʋ�ϱ�

    private void Awake()
    {
        npcTalk = GetComponent<NPC_Talk>();
    }
}

