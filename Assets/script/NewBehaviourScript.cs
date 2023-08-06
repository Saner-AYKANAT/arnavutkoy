using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject targetObject; // Etrafýnda dönmek istediðimiz obje
    public float selfRotationSpeed = 60f; // Nesnenin kendi etrafýnda dönme hýzý
    public float orbitSpeed = 20f; // Nesnenin etrafýnda dönme hýzý

    void Update()
    {
        // Nesneyi her frame'de kendi etrafýnda y ekseninde belirtilen hýzda döndür
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime);

        // Nesneyi her frame'de y ekseninde belirtilen hýzda ve belirlediðimiz obje etrafýnda döndür
        if (targetObject != null)
        {
            transform.RotateAround(targetObject.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }
}



