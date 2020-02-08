using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogType : MonoBehaviour
{
    enum Personality
    {
        COOL, WARM, ROMANTIC, ACTIVITY
    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public string Intro(int mood)
    {
        switch(mood)
        {
            case (int)Personality.COOL:
                return Cool(true);

            case (int)Personality.WARM:
                return Warm(true);                

            case (int)Personality.ROMANTIC:
                return Romantic(true);

            case (int)Personality.ACTIVITY:
                return Activity(true);

            default:
                return "UNKNOWN";
        }
    }

    public string Cool(bool first)
    {
        int index = 0;
        string Dialog = "안녕";

        if (!first)
        {//대사
            switch (index)
            {
                case 0:
                    Dialog = "";
                    break;
                
        }

        }

        //basic

        return Dialog;
    }

    public string Warm(bool first)
    {
        string Dialog = "\0";

        Dialog = "안녕하세요";

        return Dialog;
    }

    public string Romantic(bool first)
    {
        string Dialog = "\0";

        Dialog = "안녕?";

        return Dialog;
    }

    public string Activity(bool first)
    {
        string Dialog = "\0";

        Dialog = "안녕!";

        return Dialog;
    }
}
