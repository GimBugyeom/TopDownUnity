using UnityEngine;

public class NPC_Talk : MonoBehaviour 
{
    [System.Serializable]
    public class DialougeData 
    {
        public Sprite Portrait;
        public string NPCname;
        [TextArea]
        public string[] Text;
        public int TextIndex;
    }
    // ÀÌ¸§

    public DialougeData dialougeData;
    public bool IsTalkLoop;

    public int CurrentTextIndex() => dialougeData.TextIndex;
    public void IncreaseTalkIndex()
    {
        dialougeData.TextIndex = dialougeData.TextIndex + 1;

        if (dialougeData.TextIndex == dialougeData.Text.Length) 
        {
            dialougeData.TextIndex = 0;
        }
        else
        {
            dialougeData.TextIndex = dialougeData.Text.Length - 1;
        }
    }
}

