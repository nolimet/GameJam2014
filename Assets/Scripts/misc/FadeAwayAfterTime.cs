using UnityEngine;
using System.Collections;

public class FadeAwayAfterTime : MonoBehaviour {
    [SerializeField]
    float wait;
    [SerializeField]
    float fadeTime;
    [SerializeField]
    bool useSprite;

    SpriteRenderer spr;

    void Start()
    {
        if (useSprite)
        {
            spr = GetComponent<SpriteRenderer>();
        }
    }

	void Update () {
        wait -= Time.deltaTime;

        if (wait <= 0)
        {
            if (!useSprite)
            {
                renderer.material.color = new Color(1, 1, 1, renderer.material.color.a - (1 / fadeTime * Time.deltaTime));
                if (renderer.material.color.a < 0)
                    Destroy(this.gameObject);
            }
            else
            {
                spr.color = new Color(1, 1, 1, renderer.material.color.a - (1 / fadeTime * Time.deltaTime));
                if (spr.color.a < 0)
                    Destroy(this.gameObject);
            }
        }

	}
}
