using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenkDegistir : MonoBehaviour  
{
    public new GameObject light;
    public Material playerColor;
    int rPlayer, gPlayer, bPlayer;
    int rLight, gLight, bLight;
    private void Start()
    {
        int random =Random.Range(0, 6);		// Assigns one of 6 different colors as the first color
        Debug.Log(random);					// Based on rgb color system
        switch (random)
        {
            case 0:
                rPlayer = 255;
                gPlayer = 0;
                bPlayer = 0;
                rLight = 250;
                gLight = 200;
                bLight = 200;
                break;
            case 1:
                rPlayer = 255;
                gPlayer = 0;
                bPlayer = 255;
                rLight = 250;
                gLight = 200;
                bLight = 250;
                break;
            case 2:
                rPlayer = 0;
                gPlayer = 0;
                bPlayer = 255;
                rLight = 200;
                gLight = 200;
                bLight = 250;
                break;
            case 3:
                rPlayer = 0;
                gPlayer = 255;
                bPlayer = 255;
                rLight = 200;
                gLight = 250;
                bLight = 250;
                break;
            case 4:
                rPlayer = 0;
                gPlayer = 255;
                bPlayer = 0;
                rLight = 200;
                gLight = 250;
                bLight = 200;
                break;
            case 5:
                rPlayer = 255;
                gPlayer = 255;
                bPlayer = 0;
                rLight = 250;
                gLight = 250;
                bLight = 200;
                break;
        }
        BlokRenkDegistirici(new Color(colorNumberConversion(rPlayer), colorNumberConversion(gPlayer), colorNumberConversion(bPlayer)));
        light.GetComponent<Light>().color = new Color(colorNumberConversion(rLight), colorNumberConversion(gLight), colorNumberConversion(bLight));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GecmeDenetleyici"))
        {
            RenkDegistirici();
        }
    }
    private float colorNumberConversion(int num) // unity takes rgb numbers as floats between 0-1
    {
        return num / 255.0f;
    }

    private void BlokRenkDegistirici(Color color)		// changes the color of the materials
    {
        Renderer[] renderers= gameObject.transform.parent.GetComponentsInChildren<Renderer>();
        foreach(Renderer r in renderers)
        {
            r.material.color = color;
        }
    }

    void RenkDegistirici()  // determines the next color 
    {
        if (rPlayer >= 255 && gPlayer == 0 && bPlayer < 255 && bPlayer >= 0)
        {
            bPlayer += 15;
            bLight += 3;
        } else if (rPlayer > 0 && rPlayer <= 255 && gPlayer == 0 && bPlayer >= 255)
        {
            rPlayer -= 15;
            rLight -= 3;
        } else if (rPlayer == 0 && 0 <= gPlayer && gPlayer < 255 && bPlayer >= 255)
        {
            gPlayer += 15;
            gLight += 3;
        }else if (rPlayer == 0 && gPlayer >= 255 && 0<bPlayer && bPlayer <= 255)
        {
            bPlayer -= 15;
            bLight -= 3;
        }else if (0<= rPlayer && rPlayer < 255 && gPlayer >= 255 && bPlayer == 0)
        {
            rPlayer += 15;
            rLight += 3;
        }else if(rPlayer >= 255 && 0< gPlayer && gPlayer<= 255 && bPlayer == 0)
        {
            gPlayer -= 15;
            gLight -= 3;
        }

        BlokRenkDegistirici(new Color(colorNumberConversion(rPlayer), colorNumberConversion(gPlayer), colorNumberConversion(bPlayer)));
        light.GetComponent<Light>().color = new Color(colorNumberConversion(rLight), colorNumberConversion(gLight), colorNumberConversion(bLight));
    }


}
