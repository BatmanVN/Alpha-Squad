/*
 * FancyScrollView (https://github.com/setchi/FancyScrollView)
 * Copyright (c) 2020 setchi
 * Licensed under MIT (https://github.com/setchi/FancyScrollView/blob/master/LICENSE)
 */

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace FancyScrollView.Example03
{
    class Example03 : MonoBehaviour
    {
        [SerializeField] ScrollView scrollView = default;

        void Start()
        {
            List<ItemData> datas = new List<ItemData>();
            for (int i = 0; i < 1000; i++)
            {
                datas.Add(new ItemData
                {
                    Id = i,
                    Message = "A" + i
                });
            }

            scrollView.UpdateData(datas);
            scrollView.SelectCell(0);
        }
    }
}
