using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRenk : MonoBehaviour
{
    Camera kamera;
    GameObject[] renkyerleri;
    Vector2 ilk_pozisyon;
    son son_script;

    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        renkyerleri = GameObject.FindGameObjectsWithTag("renkyeri");
        ilk_pozisyon = transform.position;
        son_script = GameObject.Find("son").GetComponent<son>();
    }

    private void OnMouseDrag()
    {
        Vector3 pozisyon = kamera.ScreenToWorldPoint(Input.mousePosition);
        pozisyon.z = 0;
        transform.position = pozisyon;

    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            foreach (GameObject renkyeri in renkyerleri)
            {
                if (gameObject.name == renkyeri.name)
                {
                    float mesafe = Vector3.Distance(renkyeri.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = renkyeri.transform.position;
                        Destroy(this); 
                        son_script.level_son();
                    }
                    else
                    {
                        transform.position = ilk_pozisyon;

                    }

                }
            }
        }
    }
}
