using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeActivity : MonoBehaviour
{
    public string ActivityNormal(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕!";
                break;
            case 1:
                Dialog = "오늘도 파이팅!";
                break;
            case 2:
                Dialog = "운동이나 할러갈까";
                break;
            default:
                Dialog = "미안. 모르겠어.";
                break;
        }
        return Dialog;
    }

    public string ActivityHappy(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕!!";
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

    public string ActivityAngry(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "여어....";
                break;
            case 1:
                Dialog = "좀 기운이 없네.";
                break;
            case 2:
                Dialog = "미안. 나중에 말할게.";
                break;
            default:
                Dialog = "응?";
                break;
        }
        return Dialog;
    }

    public string ActivityFishing(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "하하하하!";
                break;
            case 1:
                Dialog = "안녕?";
                break;
            case 2:
                Dialog = "좋아! 누가 더 큰걸 낚는지 대결이다!";
                break;
            default:
                Dialog = "하하하하하하하하하하";
                break;
        }
        return Dialog;
    }
}
