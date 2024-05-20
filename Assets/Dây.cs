using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dây : MonoBehaviour
{
    [SerializeField] private Transform Day;
    [SerializeField] private Transform Moc;
    [SerializeField] private float DoDai;
   
    private void Scale()
    {
        if ( Input.GetMouseButtonDown(0) )
        {
            var newposition = Day.position;
            newposition.y += DoDai;
            Day.position = newposition;
        }
    }
    private void Update()
    {
        Scale();
        
    }



}
