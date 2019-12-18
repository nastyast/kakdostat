using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg_raz : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    [SerializeField] Sprite sprite;
    [SerializeField] Gadosti gadosti;
    bool active = true;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))

            if (!collision.CompareTag("Player")) return;
        if (Input.GetKeyDown(KeyCode.E) && collision.GetComponent<personag>().egg && active)
        {
            spriteRenderer.sprite = sprite;
            gadosti.gad++;
            active = false;
            collision.GetComponent<personag>().eggIm.SetActive(false);
        }
    }
}
