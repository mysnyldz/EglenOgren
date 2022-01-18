using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HayvanMove : MonoBehaviour
{
    Camera kamera;
    GameObject[] hayvanyerleri;
    Vector2 ilk_pozisyon;
    SonScript son_script;

    void Start()
    {
        kamera = GameObject.Find("camera").GetComponent<Camera>();
        hayvanyerleri = GameObject.FindGameObjectsWithTag("hayvangolgeleri");
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
            foreach (GameObject hayvangolgeleri in hayvanyerleri)
            {
                if (gameObject.name == hayvangolgeleri.name)
                {
                    float mesafe = Vector3.Distance(hayvangolgeleri.transform.position, transform.position);
                    if (mesafe <= 2)
                    {
                        transform.position = hayvangolgeleri.transform.position;
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
