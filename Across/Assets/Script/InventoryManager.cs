using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    const int inventorySize = 15;
    int inventoryCount;
    GameObject[] InvenItem;
    GameObject target;
    int index;
    bool fullinven;
    bool click;

    public Sprite TypeImage;
    float timer;
    public Image[] invenimage;
    // Start is called before the first frame update
    void Start()
    {
        InvenItem = new GameObject[15];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            click = true;
            SaveItem();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            
            click = false;
        }



        if (click)
        {
        
        }

    }

    void SaveItem()
    {
        if (inventoryCount <= inventorySize)
        {
            InvenItem[index] = target;
            inventoryCount++;
            index++;
            ShowInventory();

            Destroy(target.gameObject);
        }
        else
            fullinven = true;

    }

    void ShowInventory()
    {
        invenimage[index - 1].GetComponent<Image>().sprite = TypeImage;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tree")//흔들기
        {

        }
        else if (!(other.tag == "ground"))
        {
            if (!fullinven)
            {
                target = other.gameObject;

            }
        }
    }
}
