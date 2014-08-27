using UnityEngine;
using System.Collections;
namespace menu_old
{
    public class ExitGame : TriggerV2
    {
        public override void doAction()
        {
            base.doAction();
            Application.Quit();
        }
    }
}