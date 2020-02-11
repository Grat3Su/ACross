using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCharacter : Baseentity
{
    float Timee;
    float Timeer;
    public GameObject N2;
    public GameObject DIALOG;
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
                
            }

            else//암것도 안함.
            {
                if(mode == 0)//움직임
                MoveNPC();

            }
        }
    }

    void MoveNPC()
    {

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
        if(collision.tag == "citizen")//랜덤한 확률로 대화 함.
        {
            int rand = Random.Range(0, 101);

            if(rand>NPCCon)
            {//대화
                InCon = true;
                N2 = collision.gameObject;
                collision.GetComponent<NPCCharacter>().SetCon(true);
            }
        }

        if(collision.tag == "river")
        {//상태 변경
            mode = 1;//낚시
        }
    }
}
