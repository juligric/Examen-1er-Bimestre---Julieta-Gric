using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VTV : MonoBehaviour
{
    public string Patente;
    public float ModeloDeFabricacion;
    public float KilometrosRecorridos;
    public int AñoVtv;
    public int Hcppm;

    float promedioKm = 0;
    float AñoHoy = 2025;

    // Start is called before the first frame update
    void Start()
    {
        if (Patente == "" || ModeloDeFabricacion < 1900 || ModeloDeFabricacion > 2025 || KilometrosRecorridos < 0 || AñoVtv > 2025 || AñoVtv < ModeloDeFabricacion || Hcppm < 5 || Hcppm > 100 )
        {
            Debug.Log("vtv no aprobada");
            return;
        }

        promedioKm = KilometrosRecorridos / (AñoHoy - ModeloDeFabricacion);
        if (promedioKm < 10000)
            Debug.Log("VTV otorgada por dos años");

        else
        {
            Debug.Log("VTV otorgada por un año");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
