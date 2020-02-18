using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Map : MonoBehaviour
{
    public int mapsize;
    public GameObject map;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = -((int)(mapsize/2)); i <= mapsize; i++)
        {
            for (int j = -((int)(mapsize / 2)); j <= mapsize; j++)
                Instantiate(map, new Vector3(i, 0, j), Quaternion.identity);
        }
        //for(int i = 10; i>)
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
