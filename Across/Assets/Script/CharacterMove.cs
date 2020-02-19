using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public GameObject inventory;
    public float speed = 5.0f;
    bool invenOn = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0) 
        {
            dir = Vector3.left;
        }
        if (Input.GetAxisRaw("Horizontal") >0)
        {
            dir = Vector3.right;
        }

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            dir = Vector3.forward;
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            dir = Vector3.back;
        }
        transform.Translate(dir* speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (invenOn == false)
            {
                invenOn = true;
                inventory.SetActive(true);
            }
            else
            {
                invenOn = false;
                inventory.SetActive(false);
            }

        }
    }

    
}
