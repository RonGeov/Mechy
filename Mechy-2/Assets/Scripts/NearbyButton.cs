using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearbyButton : MonoBehaviour
{
    public void NearbyMap()
    {
        Application.OpenURL("http://www.google.com/maps/search/mechanic+near+me");
    }
}
