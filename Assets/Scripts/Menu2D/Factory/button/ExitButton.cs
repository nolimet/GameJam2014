using UnityEngine;
using System.Collections;
using menu.factory.action;
namespace menu
{
    namespace factory
    {
        namespace button
        {
            public class ExitButton : ButtonGeneric
            {
                public static GameObject exitButton(Material m, Font ft, int Size, TextAnchor txmach = TextAnchor.UpperLeft)
                {
                    GameObject b = MakeBase(m,ft,"Exit",Size,txmach);
                    b.AddComponent<ExitGame>();
                    b.name = "Exit";
                    return b;
                }
            }
        }
    }
}