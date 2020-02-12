using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeWarm : MonoBehaviour
{
    public string WarmNormal(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕하세요";
                break;
            case 1:
                Dialog = "오늘 날씨가 좋네요."; 
                break;
            case 2:
                Dialog = "오늘같은 날은 햇볕을 쬐야해요.";
                break;
            default:
                Dialog = "죄송해요. 모르겠네요.";
                break;
        }
        return Dialog;
    }

    public string WarmHappy(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕하세요!";
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
                Dialog = "죄송해요. 모르겠네요..";
                break;
        }
        return Dialog;
    }

    public string WarmAngry(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "아.. 안녕하세요";
                break;
            case 1:
                Dialog = "무슨일이세요?";
                break;
            case 2:
                Dialog = "죄송해요 지금은 좀..";
                break;
            default:
                Dialog = "죄송해요. 모르겠네요..";
                break;
        }
        return Dialog;
    }

    public string WarmFishing(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕하세요";
                break;
            case 1:
                Dialog = "낚시하러 오신건가요?";
                break;
            case 2:
                Dialog = "많이 낚으셨나요?";
                break;
            default:
                Dialog = "죄송해요. 모르겠네요..";
                break;
        }
        return Dialog;
    }
}
