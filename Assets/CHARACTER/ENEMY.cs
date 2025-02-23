using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Transform jugador; // Referencia al jugador
    public float radioDeteccion = 3f; // Radio de detección
    public float velocidad = 2f; // Velocidad del enemigo
    private bool persiguiendo = false;

    void Start()
    {
        // Busca al jugador automáticamente por nombre
        GameObject objJugador = GameObject.Find("PLAYER");
        if (objJugador != null)
        {
            jugador = objJugador.transform;
        }
        else
        {
            Debug.LogError("No se encontró el objeto PLAYER en la escena.");
        }
    }

    void Update()
    {
        if (jugador == null) return;

        float distancia = Vector3.Distance(transform.position, jugador.position);

        // Si el jugador está dentro del radio de detección, empieza a moverse
        if (distancia <= radioDeteccion)
        {
            persiguiendo = true;
        }

        // Si está persiguiendo, moverse hacia el jugador
        if (persiguiendo)
        {
            transform.position = Vector3.MoveTowards(transform.position, jugador.position, velocidad * Time.deltaTime);
        }
    }

    public void RecibirDaño()
    {
        Debug.Log(gameObject.name + " ha sido atacado.");
        Destroy(gameObject); // Elimina el enemigo cuando es atacado
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("AtaqueJugador"))
        {
            RecibirDaño();
        }
    }
}
