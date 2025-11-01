using UnityEngine;

public class NPC : MonoBehaviour
{
    NPC_Talk npcTalk;
    //NPC_Talk 상호작용 **
    //NPC_Move 움직이기
    //NPC_Battle 배틀하기

    private void Awake()
    {
        npcTalk = GetComponent<NPC_Talk>();
    }
}

