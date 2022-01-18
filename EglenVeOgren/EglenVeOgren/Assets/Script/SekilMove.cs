using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SekilMove : MonoBehaviour
{
    Camera kamera;
    GameObject[] sekilyerleri;
    Vector2 ilk_pozisyon;
    SonScript son_script;

    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        sekilyerleri = GameObject.FindGameObjectsWithTag("sekilgolgeleri");
        ilk_pozisyon = transform.position;
        son_script = GameObject.Find("sonuncu").GetComponent<SonScript>();
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
            foreach (GameObject sekilgolgeleri in sekilyerleri)
            {
                if (gameObject.name == sekilgolgeleri.name)
                {
                    float mesafe = Vector3.Distance(sekilgolgeleri.transform.position, transform.position);
                    if (mesafe <= 1)
                    {
                        transform.position = sekilgolgeleri.transform.position;
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
