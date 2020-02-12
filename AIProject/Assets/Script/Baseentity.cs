using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baseentity : MonoBehaviour
{
    enum Name
    {
        A, B, C, D
    }
    //성격
    //cool, warm, romantic, activity 0 1 2 3
    public int Personality;
    public int Intimacy;//친밀도
    public int EntityNum;//이름
    protected PlayerCharacter pscript;
    protected GameObject player;
    public bool YouPartner;
    protected bool InCon;
    public int NPCCon;
    protected GameObject friend;
    public int mode;

    public float Speed;
    protected Vector3 moveVelocity;
    public string GetName(int n)
    {
        switch (n)
        {
            case (int)Name.A:
                return "A";

            case (int)Name.B:
                return "B";

            case (int)Name.C:
                return "C";

            case (int)Name.D:
                return "D";

            default:
                return "UNKNOWN!";
        }
    }
}
