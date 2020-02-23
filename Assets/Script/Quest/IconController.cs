using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ActionIcons
{
    Event,
    TreasureBox,
    Shop,
    Battle,
}

public class IconController : MonoBehaviour
{
    /*public GameObject event_icon;
    public GameObject treasure_box_icon;
    public GameObject shop_icon;
    public GameObject battle_icon;*/

    public GameObject action_icons;

    void Start()
    {
        int random_number1 = (int) Random.Range(0.0f, 4.0f);
        Debug.Log(random_number1);
        float icon1_transform_position_x = -120.0f;
        switch (random_number1)
        {
            case (int) ActionIcons.Event:
                this.NewPrefabInstance("Prefabs/Quest/event_icon", icon1_transform_position_x, -170);
                //event_icon.GetComponent<Icon>().initialize(icon1_transform_position_x, -170);
                break;
            case (int) ActionIcons.TreasureBox:
                this.NewPrefabInstance("Prefabs/Quest/treasure_box_icon", icon1_transform_position_x, -170);
                //treasure_box_icon.GetComponent<Icon>().initialize(icon1_transform_position_x, -170);
                break;
            case (int) ActionIcons.Shop:
                this.NewPrefabInstance("Prefabs/Quest/shop_icon", icon1_transform_position_x, -170);
                //shop_icon.GetComponent<Icon>().initialize(icon1_transform_position_x, -170);
                break;
            case (int) ActionIcons.Battle:
                this.NewPrefabInstance("Prefabs/Quest/battle_icon", icon1_transform_position_x, -170);
                //battle_icon.GetComponent<Icon>().initialize(icon1_transform_position_x, -170);
                break;
        }

        int random_number2 = (int) Random.Range(0.0f, 4.0f);
        Debug.Log(random_number2);
        float icon2_transform_position_x = 100.0f;
        switch (random_number2)
        {
            case (int)ActionIcons.Event:
                this.NewPrefabInstance("Prefabs/Quest/event_icon", icon2_transform_position_x, -170);
                break;
            case (int)ActionIcons.TreasureBox:
                this.NewPrefabInstance("Prefabs/Quest/treasure_box_icon", icon2_transform_position_x, -170);
                break;
            case (int)ActionIcons.Shop:
                this.NewPrefabInstance("Prefabs/Quest/shop_icon", icon2_transform_position_x, -170);
                break;
            case (int)ActionIcons.Battle:
                this.NewPrefabInstance("Prefabs/Quest/battle_icon", icon2_transform_position_x, -170);
                break;
        }

        /*Vector3 battle_icon_position = this.battle_icon.transform.position;
        battle_icon_position.x += 120.0f;
        this.battle_icon.transform.position = battle_icon_position;

        Vector3 event_icon_position = this.event_icon.transform.position;
        event_icon_position.x += 0.0f;
        this.event_icon.transform.position = event_icon_position;

        Vector3 shop_icon_position = this.shop_icon.transform.position;
        shop_icon_position.x -= 120.0f;
        this.shop_icon.transform.position = shop_icon_position;

        Vector3 treasure_box_position = this.treasure_box_icon.transform.position;
        treasure_box_position.x -= 240.0f;
        this.treasure_box_icon.transform.position = treasure_box_position;*/
    }
 //   "Prefabs/Effects/Prefab名"
    private void NewPrefabInstance(string prefab_name, float position_x, float position_y)
    {
        // プレハブを取得
        GameObject prefab = (GameObject)Resources.Load(prefab_name);

        Vector3 vector3 = new Vector3(0, 0, 0);
        
        // プレハブからインスタンスを生成
        GameObject obj = (GameObject)Instantiate(prefab, vector3, Quaternion.identity);
        
        // 作成したオブジェクトを子として登録
        obj.transform.parent = action_icons.transform;

        //
        obj.SetActive(true);

        //UIのポジションを設定
        obj.GetComponent<RectTransform>().localPosition = new Vector3(position_x, position_y, 0);
    }

    void Update()
    {
        
    }
}
