using UnityEngine;
using System.Collections;
using menu.factory.action;
namespace menu
{
    namespace factory
    {
        namespace button
        {
            public class ButtonGeneric : MonoBehaviour
            {
                /*
                 * base class for button
                 * 
                 * 
                 */
                static protected GameObject MakeBase(Material m,Font ft ,string tx, int fs, TextAnchor txmach = TextAnchor.UpperLeft)
                {
                    GameObject b = new GameObject();
                    MeshRenderer mr = b.AddComponent<MeshRenderer>();
                    mr.material = m;
                    TextMesh txm = b.AddComponent<TextMesh>();
                    txm.font = ft;
                    txm.anchor = txmach;
                    txm.fontSize = fs*ButtonFactory.fontScale;
                    b.transform.localScale = b.transform.localScale / ButtonFactory.fontScale;
                    txm.text = tx;
                    

                    b.AddComponent<BoxCollider2D>();
                        return b;
                }
            }
        }
    }
}