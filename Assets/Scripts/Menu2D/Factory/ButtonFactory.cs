﻿using UnityEngine;
using System.Collections;
using menu.factory.button;
namespace menu
{
    namespace factory
    {
        public class ButtonFactory : MonoBehaviour
        {
            #region TextRelated
            public const int fontScale = 4;
            //Find fix for loading materials;
            static public Material fontMat;
            static public Font font;
            int fontSize;
            #endregion

            #region Enum's
            public enum Buttons
            {
                Exit,
                ChangeMenu,
                Link,
                LevelLink
            }
            #endregion

            //every button needs to have own handler
            //bug Currently:
            //fontMat,font need to be set solid somewhere in a manager of sorts
            #region Creator
            //Creats a button and calls the need functions
            public static GameObject makeButton(Buttons bu, Transform parent, Vector3 pos = new Vector3(), int fontSize = 20, string text = "", int ToMenu = -1, string url = "", TextAnchor txmach = TextAnchor.UpperLeft)
            {
                GameObject b = null;
                switch (bu)
                {
                    case Buttons.Exit:
                       b = ExitButton.exitButton(fontMat, font, fontSize,txmach);
                        break;
                    case Buttons.ChangeMenu:
                        b = ChangeMenuButton.changeMenuButton(fontMat, font, fontSize, text, ToMenu, txmach);
                        break;
                    case Buttons.Link:
                        b = OpenLinkButton.openLinkButton(fontMat, font, fontSize, text, url, txmach);
                        break;
                    case Buttons.LevelLink:
                        b = menu.factory.button.LoadLevelButton.loadLevelButton(fontMat, font, fontSize, text, url, txmach);
                        break;
                    default:
                        b=new GameObject();
                        b.name="Buttons.##Error##";
                        Destroy(b, 0.1f);
                        break;

                }
                b.transform.parent = parent;
                b.transform.position = pos;

                return b;
            }
            #endregion
        }
    }
}