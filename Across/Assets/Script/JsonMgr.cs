using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;

public class Item
{
    public int ID;
    public string Name;
    public int Type;
    public int Price;
    
    public Item(int type, int id, string name,  int price)
    {
        ID = id;
        Name = name;
        Type = type;
        Price = price;
    }
}

enum ItemType
{
    TOOL, FRUIT, CLOTH, FUNITURE, FISH, SHELL
};

public class JsonMgr : MonoBehaviour
{
    public List<Item> ItemList = new List<Item>();
    // Start is called before the first frame update
    void Start()
    {
        ItemList.Add(new Item((int)ItemType.FRUIT, 0, "사과", 100));
        
    }

    public void Save()
    {
        JsonData ItemJson = JsonMapper.ToJson(ItemList);

        File.WriteAllText(Application.dataPath + "/ItemData.json", ItemJson.ToString());
    }


}
