using UnityEngine;
using System.Collections;
namespace menu
{
    namespace factory
    {
        namespace action
        {
            public class LoadLevel : GenericAction
            {
                string url;

                bool loading = false;
                bool load = false;

                float timer = 1.3f;

                public void init(string _url){
                    url = _url;
                }

                public override void doAction()
                {
                    load = true;
                    GameObject.FindGameObjectWithTag(Statics.CurtainTag).GetComponent<Animator>().SetTrigger("Ativate");
                }

                void Update()
                {
                    if (load)
                    {
                        timer -= Time.deltaTime;
                        if (!loading && timer <= 0)
                        {
                            Application.LoadLevel(url);
                            //transform.parent.parent.gameObject.GetComponent<Loader>().SyncLoadLevel(url);
                            loading = true;
                        }
                    }
                }
            }
        }
    }
}