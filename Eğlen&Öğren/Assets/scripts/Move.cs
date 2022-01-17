using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Camera kamera;
    GameObject[] hayvanyerleri;
    Vector2 ilk_pozisyon;
    son son_script;

    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        hayvanyerleri = GameObject.FindGameObjectsWithTag("hayvanyeri");
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
            foreach (GameObject hayvanyeri in hayvanyerleri)
            {
                if (gameObject.name == hayvanyeri.name)
                {
                    float mesafe = Vector3.Distance(hayvanyeri.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = hayvanyeri.transform.position;
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
