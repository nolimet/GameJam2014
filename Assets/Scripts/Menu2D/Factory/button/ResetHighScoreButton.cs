using UnityEngine;
using System.Collections;
namespace menu
{
    namespace factory
    {
        namespace button
        {
            public class ResetHighScoreButton : ButtonGeneric
            {
                static public GameObject resetHighScoreButton(Material m, Font ft, int Size, string text, string url, TextAnchor txmach = TextAnchor.UpperLeft)
                {
                    GameObject b = MakeBase(m, ft, "Rest HighScore", Size, txmach);

                    return b;
                }
                
            }
        }
    }
}