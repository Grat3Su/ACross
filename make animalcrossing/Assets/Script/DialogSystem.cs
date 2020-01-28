using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    const int NoPersonality = 3;
    bool DialogStart;
    bool InConversation;
    bool DialogEnd;

    int[] ContactNum;
    public Text Dialog;
    public GameObject Dialogpanel;
    // Start is called before the first frame update
    void Start()
    {
        ContactNum = new int[NoPersonality+1];

        for(int i = 0; i< NoPersonality+1; i++)
        {
            ContactNum[i] = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(DialogStart)
        {
            Dialogpanel.SetActive(true);
            InConversation = true;
        }
        else if(DialogEnd)
        {
            Dialogpanel.SetActive(false);
            InConversation = false;
        }

        if(InConversation)
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
