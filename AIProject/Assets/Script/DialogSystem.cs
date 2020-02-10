using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    public Text Dialog;
    public Text NameBox;
    public GameObject Dialogpanel;
    public GameObject SelectPanel;

    const int NoPersonality = 3;
    public bool DialogStart;//대화시작
    bool InConversation;//대화중
    bool DialogEnd;//대화끝
    bool SelectOn;
    float Timer;

    public GameObject player;
    PlayerCharacter pscript;

    DialogType conScript;

    GameObject npc1;
    GameObject npc2;



    NPCCharacter npc1Script;
    NPCCharacter npc2Script;

    int MaxScript;

    int dialogindex;

    // Start is called before the first frame update
    void Start()
    {
        pscript = player.GetComponent<PlayerCharacter>();
        conScript = gameObject.GetComponent<DialogType>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogStart)
        {
            Dialogpanel.SetActive(true);
            InConversation = true;
            DialogStart = false;
            DialogEnd = false;            
        }
        else if (DialogEnd)
        {
            Dialogpanel.SetActive(false);
            InConversation = false;
            npc1Script.SetPartner(false);
        }

        if (InConversation)
        {
                UpdateDialog();           
        }
    }

    void UpdateDialog()//상대가 하나냐 둘이냐에 따라 다름.
    {//업데이트를 어떻게 할까.,.,
        Baseentity Bplayer = player.GetComponent<Baseentity>();
        npc1Script = npc1.GetComponent<NPCCharacter>();
        MaxScript = 2;
        npc1Script.SetPartner(true);
            DirectDialog();

        if (dialogindex > MaxScript)
            SetEnd(true);
    }

    void DirectDialog()
    {        
        npc1Script = npc1.GetComponent<NPCCharacter>();
        NameBox.text = npc1Script.GetName(npc1Script.Personality);
        MaxScript = 2;
        switch (dialogindex)
        {
            case 0:  case 2:
                Dialog.text = conScript.Intro(npc1Script.Personality, dialogindex);
                break;
            case 1:
                Dialog.text = conScript.Intro(npc1Script.Personality, dialogindex);
                SelectOn = true;
                SelectPanel.SetActive(true);
                break;
            case 3:
                break;
            default:
                Dialog.text = "에러에러에러에러에러에러에러에러에러에러";
                break;
        }
    }


    public void SelectionYes()
    {
        dialogindex++;
        SelectOn = false;
        SelectPanel.SetActive(false);
    }
    public void SelectionNo()
    {
        SelectOn = false;
        SelectPanel.SetActive(false);
        SetEnd(true);
    }

    public void IncIndex()
    {
        if (!SelectOn)
            dialogindex++;
    }

    public void SetStart(bool isStart)
    {
        DialogStart = isStart;
    }

    public void SetEnd(bool isEnd)
    {
        npc1Script.YouPartner = false;
        DialogEnd = isEnd;
        dialogindex = 0;
    }

    public bool GetEnd()
    {
        return DialogEnd;
    }

    public void SetPartner(GameObject P)
    {
        npc1 = P;
    }

    public void SetNpc2(GameObject P)
    {
        npc2 = P;
    }
}
