using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogType : MonoBehaviour
{
    enum Personality
    {
        COOL, WARM, ROMANTIC, ACTIVITY
    }
    enum Mood//대화 주제
    {
        NORMAL, HAPPY, ANGRY, FISHING
    }

    int index;
    GameObject Target;

    public void SetTarget(GameObject t)
    {
        Target = t;
    }

    public string Intro(int n)
    {
        switch (Target.GetComponent<NPCCharacter>().Personality)
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
    public TypeCool cool;
    public string Cool(int Dindex)
    {
        string Dialog = "\0";
        switch (Target.GetComponent<NPCCharacter>().mode)
        {
            case (int)Mood.NORMAL:
                Dialog = cool.CoolNormal(Dindex);
                break;
            case (int)Mood.HAPPY:
                Dialog = cool.CoolHappy(Dindex);
                break;
            case (int)Mood.ANGRY:
                Dialog = cool.CoolAngry(Dindex);
                break;
            case (int)Mood.FISHING:
                Dialog = cool.CoolFishing(Dindex);
                break;
            default:
                Dialog = "미안.";
                break;

        }

        //basic

        return Dialog;
    }
    public TypeWarm warm;
    public string Warm(int Dindex)
    {
        string Dialog = "\0";
        switch (Target.GetComponent<NPCCharacter>().mode)
        {
            case (int)Mood.NORMAL:
                Dialog = warm.WarmNormal(Dindex);
                break;
            case (int)Mood.HAPPY:
                Dialog = warm.WarmHappy(Dindex);
                break;
            case (int)Mood.ANGRY:
                Dialog = warm.WarmAngry(Dindex);
                break;
            case (int)Mood.FISHING:
                Dialog = warm.WarmFishing(Dindex);
                break;
            default:
                Dialog = "죄송해요. 모르겠네요.";
                break;
        }

        return Dialog;
    }

    public TypeRomantic romantic;
    public string Romantic(int Dindex)
    {
        string Dialog = "\0";

        switch (Target.GetComponent<NPCCharacter>().mode)
        {
            case (int)Mood.NORMAL:
                Dialog = romantic.RomanticNormal(Dindex);
                break;
            case (int)Mood.HAPPY:
                Dialog = romantic.RomanticHappy(Dindex);
                break;
            case (int)Mood.ANGRY:
                Dialog = romantic.RomanticAngry(Dindex);
                break;
            case (int)Mood.FISHING:
                Dialog = romantic.RomanticFishing(Dindex);
                break;
            default:
                Dialog = "응? 뭐라고?.";
                break;
        }

        return Dialog;
    }

    public TypeActivity activity;
    public string Activity(int Dindex)
    {
        string Dialog = "\0";

        switch (Target.GetComponent<NPCCharacter>().mode)
        {
            case (int)Mood.NORMAL:
                Dialog = activity.ActivityNormal(Dindex);
                break;
            case (int)Mood.HAPPY:
                Dialog = activity.ActivityHappy(Dindex);
                break;
            case (int)Mood.ANGRY:
                Dialog = activity.ActivityAngry(Dindex);
                break;
            case (int)Mood.FISHING:
                Dialog = activity.ActivityFishing(Dindex);
                break;
            default:
                Dialog = "미안. 모르겠어.";
                break;
        }

        return Dialog;
    }
}
