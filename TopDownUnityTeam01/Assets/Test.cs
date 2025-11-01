using UnityEngine;

public class Test : MonoBehaviour
{
    public NPC_Talk talk;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {

            DialogueSystem.Instance.TypeText(talk);
        }

    }
}
