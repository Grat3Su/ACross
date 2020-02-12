using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCharacter : Baseentity
{
    float Timee;
    float Timeer;
    public GameObject N2;
    public GameObject DIALOG;
    float timer;
    public float DelayTimer;
    void Start()
    {
        player = GameObject.Find("char");
        pscript = player.GetComponent<PlayerCharacter>();
        InCon = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (YouPartner)//플레이어와 대화
        {
            if (InCon)
            {
                timer = 0;
                //대화중
                DIALOG.GetComponent<DialogSystem>().SetNpc2(N2);
            }
            else
            {

            }
        }
        else//아님
        {
            if (InCon)//NPC랑 대화
            {
                timer += Time.deltaTime;
                if(timer > DelayTimer)
                {
                    timer = 0;
                    InCon = false;
                }
            }

            else//암것도 안함.
            {
                timer += Time.deltaTime;
                if (timer > DelayTimer)
                {
                    timer = 0;
                    if(mode!=3)
                    ModeChange();
                }

                if (mode == 0)//움직임
                    MoveNPC();
            }
        }
    }

    void MoveNPC()
    {

    }
        
    void ModeChange()
    {
        int rand = Random.Range(0, 100);

        if(rand > 40)
        {
            mode = 0;        
        }
        else if (rand > 20)
        {
            mode = 1;
        }
        else if (rand > 0)
        {
            mode = 2;
        }
    }

    public bool GetCon()
    {
        return InCon;
    }

    public void SetCon(bool setcon)
    {
        InCon = setcon;
    }

    public void SetPartner(bool setPartner)
    {
        YouPartner = setPartner;
    }

    private void OnTriggerEnter2D(Collider2D collision)//다른 NPC와 부딪힘. 
    {
        if (collision.tag == "citizen")//랜덤한 확률로 대화 함.
        {
            int rand = Random.Range(0, 101);

            if (rand > NPCCon)
            {//대화
                InCon = true;
                N2 = collision.gameObject;
                collision.GetComponent<NPCCharacter>().SetCon(true);
            }
        }

        if (collision.tag == "river")
        {//상태 변경
            mode = 3;//낚시
        }
    }
    private void OnTriggerExit2D(Collider2D collision)//다른 NPC와 부딪힘. 
    {
        if (collision.tag == "river")
        {//상태 변경
            mode = 0;//낚시 끝
        }
    }

    public bool getIncon()
    {
        return InCon;
    }
}
