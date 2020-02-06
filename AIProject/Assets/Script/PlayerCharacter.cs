using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class PlayerCharacter : Baseentity
{
    public GameObject[] partner;
    DialogSysyem daehwachang;



    public List<GameObject> FoundObjects;
    public GameObject enemy;
    public float shortDis;
    // Start is called before the first frame update
    void Start()
    {
        partner = new GameObject[3];//0은 자신. 1은 대화상대.ㅣ 3은 글쎄!
        partner[0] = gameObject;

        daehwachang = GameObject.Find("Dialog").GetComponent<DialogSysyem>();

        FoundObjects = new List<GameObject>(GameObject.FindGameObjectsWithTag("citizen"));
        shortDis = Vector3.Distance(gameObject.transform.position, FoundObjects[0].transform.position); // 첫번째를 기준으로 잡아주기 

        enemy = FoundObjects[0]; // 첫번째를 먼저 

        foreach (GameObject found in FoundObjects)
        {
            float Distance = Vector3.Distance(gameObject.transform.position, found.transform.position);

            if (Distance < shortDis) // 위에서 잡은 기준으로 거리 재기
            {
                enemy = found;
                shortDis = Distance;
            }
        }
        Debug.Log(enemy.name);
    }

    private void Update()
    {
       
    }


    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        if (!EventSystem.current.IsPointerOverGameObject())
    //        { 
    //            Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //        Ray2D ray = new Ray2D(wp, Vector2.zero);
    //        RaycastHit2D[] hits = Physics2D.RaycastAll(ray.origin, ray.direction);

    //            foreach (var hit in hits)
    //            {
    //                if (!hit.collider.gameObject.CompareTag("citizen"))
    //                    continue;
    //                else
    //                {
    //                    daehwachang.SetStart(true);
    //                    partner[1] = hit.collider.gameObject;
    //                }                   
    //            }
    //        }
    //    }

    //    if(daehwachang.GetEnd())
    //    {
    //        partner[1] = null;
    //        partner[2] = null;
    //    }
    //}
}
