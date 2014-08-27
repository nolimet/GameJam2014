﻿using UnityEngine;
using System.Collections;
using menu.factory.action;
namespace menu
{
    namespace factory
    {
        namespace button
        {
            public class ChangeMenuButton : ButtonGeneric
            {
                public static GameObject changeMenuButton(Material m, Font ft, int Size, string text,int toMenu, TextAnchor txmach = TextAnchor.UpperLeft)
                {
                    GameObject b = MakeBase(m,ft,text,Size,txmach);
                    ChangeMenu cm = b.AddComponent<ChangeMenu>();
                    cm.OpenMenuID = toMenu;
                    b.name = text;

                    return b;
                }
            }
        }
    }
}
