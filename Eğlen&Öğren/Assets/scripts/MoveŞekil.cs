using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveŞekil : MonoBehaviour
{
    Camera kamera;
    GameObject[] sekilyerleri;
    Vector2 ilk_pozisyon;
    son son_script;

    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        sekilyerleri = GameObject.FindGameObjectsWithTag("sekilyeri");
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
            foreach (GameObject sekilyeri in sekilyerleri)
            {
                if (gameObject.name == sekilyeri.name)
                {
                    float mesafe = Vector3.Distance(sekilyeri.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = sekilyeri.transform.position;
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
