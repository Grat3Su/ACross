using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSysyem : MonoBehaviour
{
    const int NoPersonality = 3;
    public bool DialogStart;//대화시작
    bool InConversation;//대화중
    bool DialogEnd;//대화끝
    bool SelectOn;

    int[] ContactNum;
    public Text Dialog;
    public Text NameBox;
    public GameObject Dialogpanel;
    public GameObject SelectPanel;

    public GameObject player;
    PlayerCharacter pscript;

    Baseentity npc1;
    Baseentity npc2;

    int MaxScript;

    int dialogindex;

    void Start()
    {
        ContactNum = new int[NoPersonality + 1];

        for (int i = 0; i < NoPersonality + 1; i++)
        {
            ContactNum[i] = 0;
        }
        pscript = player.GetComponent<PlayerCharacter>();
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
        }

        if (InConversation)
        {
            UpdateDialog();
        }
    }

    void UpdateDialog()//상대가 하나냐 둘이냐에 따라 다름.
    {//업데이트를 어떻게 할까.,.,
        Baseentity player = pscript.partner[0].GetComponent<Baseentity>();
        npc1 = pscript.partner[1].GetComponent<Baseentity>();
        MaxScript = 2;

        if (pscript.partner[2] != null)
        {
            npc2 = pscript.partner[2].GetComponent<Baseentity>();
            MaxScript = 4;
            MultyDialog();
        }
        else
        {
            DirectDialog();
        }




        npc1.YouPartner = false;
        if (dialogindex > MaxScript)
            SetEnd(true);
    }

    void MultyDialog()
    {
        switch (dialogindex)
        {
            case 0:
                NameBox.text = npc1.GetName(npc1.EntityNum);//이름 업데이트
                Dialog.text = "인사";
                break;
            case 1:
                NameBox.text = npc2.GetName(npc1.EntityNum);//이름 업데이트
                Dialog.text = "무슨일이야?";
                SelectOn = true;
                SelectPanel.SetActive(true);
                break;
            case 2:
                NameBox.text = npc1.GetName(npc1.EntityNum);//이름 업데이트
                Dialog.text = "대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2";
                break;
            case 3:
                NameBox.text = npc2.GetName(npc1.EntityNum);//이름 업데이트
                Dialog.text = "대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2";
                break;
            case 4:
                NameBox.text = npc1.GetName(npc1.EntityNum);//이름 업데이트
                Dialog.text = "대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2";
                break;
            default:
                Dialog.text = "에러에러에러에러에러에러에러에러에러에러";
                break;
        }
    }

    void DirectDialog()
    {
        MaxScript = 2;
        switch (dialogindex)
        {
            case 0:
                Dialog.text = "인사";
                break;
            case 1:
                Dialog.text = "무슨일이야?";
                SelectOn = true;
                SelectPanel.SetActive(true);
                break;
            case 2:
                Dialog.text = "대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2대화2";
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
        DialogEnd = isEnd;
        dialogindex = 0;
    }

    public bool GetEnd()
    {
        return DialogEnd;
    }
}
