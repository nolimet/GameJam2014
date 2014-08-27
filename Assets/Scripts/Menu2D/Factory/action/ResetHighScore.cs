using UnityEngine;
using System.Collections;
namespace menu
{
    namespace factory
    {
        namespace action
        {
            public class ResetHighScore : GenericAction
            {
                public override void doAction()
                {
                    Statics.HighestScore = 0;
                }
            }
        }
    }
}