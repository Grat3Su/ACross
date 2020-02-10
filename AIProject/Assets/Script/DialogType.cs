using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogType : MonoBehaviour
{
    enum Personality
    {
        COOL, WARM, ROMANTIC, ACTIVITY
    }


    int index;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public string Intro(int mood, int n)
    {
        switch (mood)
        {
            case (int)Personality.COOL:
                return Cool(n);

            case (int)Personality.WARM:
                return Warm(n);

            case (int)Personality.ROMANTIC:
                return Romantic(n);

            case (int)Personality.ACTIVITY:
                return Activity(n);

            default:
                return "UNKNOWN";
        }
    }

    public string Cool(int Dindex)
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

        //basic

        return Dialog;
    }

    public string Warm(int Dindex)
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

    public string Romantic(int Dindex)
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

    public string Activity(int Dindex)
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
}
