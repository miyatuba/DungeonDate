using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icon : MonoBehaviour
{

    void Start()
    {
        
    }

    /// <summary>
    /// アクティブにし、既定の位置に配置。
    /// </summary>
    public void initialize(float x, float y)
    {
        this.gameObject.GetComponent<RectTransform>().localPosition = new Vector3(x, y, 0);
        this.gameObject.SetActive(true);
    }

    void Update()
    {
        
    }
}
