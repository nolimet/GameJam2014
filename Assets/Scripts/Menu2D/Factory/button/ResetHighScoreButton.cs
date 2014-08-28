using UnityEngine;
using System.Collections;
using menu.factory.action;
namespace menu
{
    namespace factory
    {
        namespace button
        {
            public class ResetHighScoreButton : ButtonGeneric
            {
                static public GameObject resetHighScoreButton(Material m, Font ft, int Size, TextAnchor txmach = TextAnchor.UpperLeft)
                {
                    GameObject b = MakeBase(m, ft, "Reset HighScore", Size, txmach);
                    b.AddComponent<ResetHighScore>();

                    return b;
                }
                
            }
        }
    }
}