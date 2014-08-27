using UnityEngine;
using System.Collections;
using menu.factory.action;
namespace menu
{
    namespace factory
    {
        namespace button
        {
            public class OpenLinkButton : ButtonGeneric
            {
               static public GameObject openLinkButton(Material m, Font ft, int Size, string text, string url, TextAnchor txmach = TextAnchor.UpperLeft)
                {
                    GameObject b = MakeBase(m, ft, text, Size,txmach);
                    b.AddComponent<Link>().init(url);
                    return b;
                }
            }
        }
    }
}