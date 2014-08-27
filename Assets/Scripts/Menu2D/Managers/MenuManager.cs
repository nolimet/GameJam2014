using UnityEngine;
using System.Collections;
using menu.factory.action;
namespace menu
{
    [RequireComponent(typeof(HitRayFirere))]
    [RequireComponent(typeof(Loader))]
    public class MenuManager : MonoBehaviour
    {

        public ChangeMenu[] buttons;
        public menu_old.TriggerV2[] LegacyButtons;
        public MoveToV2[] Menus;
        public int currentMenuID;
        private int MenuLastFrame;

        public bool locked = false;
        // Use this for initialization
        void Start()
        {
            buttons = GetComponentsInChildren<ChangeMenu>();
            LegacyButtons = GetComponentsInChildren<menu_old.TriggerV2>();

            for (int i = 0; i < Menus.Length; i++)
            {
                Menus[i].menuID = i;
               if(Application.isEditor)
                   Menus[i].name = "[" + i + "]" + Menus[i].name;
            }
            Menus[0].move = true;
            
        }

        // Update is called once per frame
        void Update()
        {
            if (!locked)
            {
                int l = buttons.Length;
                int k = Menus.Length;
                int m = LegacyButtons.Length;
                for (int i = 0; i < l; i++)
                {
                    if (buttons[i].State)
                    {
                        buttons[i].State = false;
                        for (int j = 0; j < k; j++)
                        {
                            Menus[j].move = false;
                            Menus[j].atNewPos = false;
                            if (Menus[j].menuID == buttons[i].OpenMenuID)
                            {
                                Menus[j].move = true;
                                currentMenuID = j;
                            }
                        }
                    }
                }
                for (int e = 0; e < m; e++)
                {
                    if (LegacyButtons[e].State)
                    {
                        LegacyButtons[e].State = false;
                        for (int j = 0; j < k; j++)
                        {
                            Menus[j].move = false;
                            Menus[j].atNewPos = false;
                            if (Menus[j].menuID == LegacyButtons[e].OpenMenuID)
                            {
                                Menus[j].move = true;
                                currentMenuID = j;
                            }
                        }
                    }
                }
            }

        }
    }
}
