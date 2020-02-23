using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Collections;

namespace Assets.Script.Common
{

    public class ScrollViewHorizantal : MonoBehaviour
    {
        [SerializeField]
        private ItemIconPanel itemPanelPrefab;

        [SerializeField]
        private GameObject content;

        void Start()
        {
            CreatList();
        }

        public void CreatList()
        {
            for (int i = 0; i < 16; i++)
            {
                var itemPanel = Instantiate(itemPanelPrefab, content.transform);

                itemPanel.OnClick();
            }
        }
    }
}
