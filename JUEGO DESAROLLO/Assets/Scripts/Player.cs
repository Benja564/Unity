using UnityEngine;

public class Player : MonoBehaviour{
    private Rigidbody rb;
    public float velocidad = 10;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    void Update(){
        
    }

    private void FixedUpdate() {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");
        Vector3 movimiento = new Vector3(movimientoH*-1, 0.0f, movimientoV*-1);
        rb.AddForce(movimiento * velocidad);
    }
}
