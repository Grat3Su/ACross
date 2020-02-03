using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerCharacter : Baseentity
{
    public GameObject[] partner;
    DialogSysyem daehwachang;
    // Start is called before the first frame update
    void Start()
    {
        partner = new GameObject[3];//0은 자신. 1은 대화상대.ㅣ 3은 글쎄!
        partner[0] = gameObject;

        daehwachang = GameObject.Find("Dialog").GetComponent<DialogSysyem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!EventSystem.current.IsPointerOverGameObject())
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
                        partner[1] = hit.collider.gameObject;
                    }                   
                }
            }
        }

        if(daehwachang.GetEnd())
        {
            partner[1] = null;
            partner[2] = null;
        }
    }
}
