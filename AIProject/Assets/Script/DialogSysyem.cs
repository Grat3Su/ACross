using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSysyem : MonoBehaviour
{
    const int NoPersonality = 3;
    bool DialogStart;//대화시작
    bool InConversation;//대화중
    bool DialogEnd;//대화끝

    int[] ContactNum;
    public Text Dialog;
    public Text NameBox;
    public GameObject Dialogpanel;

    void Start()
    {
        ContactNum = new int[NoPersonality + 1];

        for (int i = 0; i < NoPersonality + 1; i++)
        {
            ContactNum[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (DialogStart)
        {
            Dialogpanel.SetActive(true);
            InConversation = true;
            DialogStart = false;
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

    void UpdateDialog()
    {//업데이트를 어떻게 할까.,.,
        Dialog.text = "gdgd";
    }

    public void SetStart(bool isStart)
    {
        DialogStart = isStart;
    }

    public void SetEnd(bool isEnd)
    {
        DialogEnd = isEnd;
    }
}
