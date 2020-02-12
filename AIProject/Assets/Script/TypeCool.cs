using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeCool : MonoBehaviour
{
    public string CoolNormal(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕";
                break;
            case 1:
                Dialog = "나한테 할말있어?";
                break;
            case 2:
                Dialog = "뭔데?";
                break;
            default:
                Dialog = "미안.";
                break;
        }
        return Dialog;
    }

    public string CoolHappy(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "여, 안녕";
                break;
            case 1:
                Dialog = "행복1";
                break;
            case 2:
                Dialog = "행복2";
                break;
            case 3:
                Dialog = "행복3";
                break;
            default:
                Dialog = "미안.";
                break;
        }
        return Dialog;
    }

    public string CoolAngry(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "뭐야";
                break;
            case 1:
                Dialog = "할말있어?";
                break;
            case 2:
                Dialog = "하지마";
                break;
            default:
                Dialog = "미안.";
                break;
        }
        return Dialog;
    }

    public string CoolFishing(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕";
                break;
            case 1:
                Dialog = "나한테 할말있어?";
                break;
            case 2:
                Dialog = "멍때리는게 아니야. 낚시라고.";
                break;
            default:
                Dialog = "미안.";
                break;
        }
        return Dialog;
    }
}
