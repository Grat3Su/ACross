using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeRomantic : MonoBehaviour
{
    public string RomanticNormal(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕?";
                break;
            case 1:
                Dialog = "날 만나러 온거야?";
                break;
            case 2:
                Dialog = "정말? 고마워.";
                break;
            default:
                Dialog = "응? 못들었어.";
                break;
        }
        return Dialog;
    }

    public string RomanticHappy(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕? 어서와.";
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

    public string RomanticAngry(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "..안녕.";
                break;
            case 1:
                Dialog = "일부러 찾아준거야?";
                break;
            case 2:
                Dialog = "미안. 지금은 별로 말할 기분이 아니야.";
                break;
            default:
                Dialog = "응? 못들었어.";
                break;
        }
        return Dialog;
    }

    public string RomanticFishing(int Dindex)
    {
        string Dialog = "\0";

        switch (Dindex)
        {
            case 0:
                Dialog = "안녕. 여기서 보는구나.";
                break;
            case 1:
                Dialog = "낚시 해보고싶어?";
                break;
            case 2:
                Dialog = "좋아. 그럼 내가 가르쳐줄게.";
                break;
            default:
                Dialog = "응? 못들었어.";
                break;
        }
        return Dialog;
    }
}
