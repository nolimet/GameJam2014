using UnityEngine;
using System.Collections;


namespace menu_old
{
    [RequireComponent(typeof(BoxCollider2D))]
    public class TriggerV2 : MonoBehaviour
    {
        public int OpenMenuID;
        public bool Disabled = false;
        public bool State = false;

        [SerializeField]
        float waitTimer;
        [SerializeField]
        bool UseTimer;

        protected virtual void Start()
        {
            if (Disabled)
            {
                GetComponent<TextMesh>().renderer.material.color = Color.gray;
            }
        }

        public virtual void doAction()
        {
            if (!Disabled)
            {
                State = true;
            }
        }
        protected virtual void OnMouseClick()
        {
            if (!Disabled)
            {
                State = true;
            }
        }

        void Update()
        {
            if (UseTimer)
            {
                waitTimer -= Time.deltaTime;
                if (waitTimer < 0)
                    State = true;
            }

        }
    }
}