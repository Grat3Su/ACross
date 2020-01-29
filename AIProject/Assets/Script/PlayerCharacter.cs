using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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

                GameObject can = hit.collider.gameObject;

                can.GetComponent<Animator>().SetTrigger("Disapear");
            }
        }
    }
}
