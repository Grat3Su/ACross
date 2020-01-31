using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : Baseentity
{
    public GameObject[] partner;
    int index;
    DialogSysyem daehwachang;
    // Start is called before the first frame update
    void Start()
    {
        partner = new GameObject[3];//0은 자신. 1은 대화상대.ㅣ 3은 글쎄!
        partner[0] = gameObject;
        index = 1;

        daehwachang = GameObject.Find("Dialog").GetComponent<DialogSysyem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Ray2D ray = new Ray2D(wp, Vector2.zero);
            RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction);

            foreach (var hit in hits)
            {
                if (!hit.collider.gameObject.CompareTag("citizen"))
                    continue;
                else
                {
                    daehwachang.SetStart(true);
                    partner[index] = hit.collider.gameObject;
                }
                //GameObject can = hit.collider.gameObject;

            }
        }
    }
}
