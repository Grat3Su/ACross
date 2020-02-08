using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerCharacter : Baseentity
{
    public GameObject[] partner;
    DialogSysyem daehwachang;
    int maxArr;
    Vector3 Distance;
    float ShortDistance;
    int SelectPartner;

    void Start()
    {
        daehwachang = GameObject.Find("Dialog").GetComponent<DialogSysyem>();
        ShortDistance = 10000000;
    }

    private void Update()
    {
        PlayerMove();

        if(Input.GetKeyDown(KeyCode.Space))
        {
            maxArr = partner.Length;
            for (int i = 0; i< 3; i++)
            {
                Distance = gameObject.transform.position - partner[i].transform.position;

                if(Distance.magnitude < ShortDistance)
                {
                    ShortDistance = Distance.magnitude;
                    SelectPartner = i;
                }
            }

            if(Distance.magnitude < 5)//일정 거리 이하. 대화 가능.
            {
                Debug.Log("대화");
                daehwachang.SetStart(true);
                daehwachang.SetPartner(partner[SelectPartner]); 
            }
        }
    }

    void PlayerMove()
    {
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            moveVelocity = Vector3.left;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            moveVelocity = Vector3.down;
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            moveVelocity = Vector3.up;
        }
        else
        {
            moveVelocity = Vector3.zero;
        }

        transform.position += moveVelocity * Speed * Time.deltaTime;
    }

}
