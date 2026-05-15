using UnityEngine;

public class Star : MonoBehaviour
{
    public AudioSource collect_sound;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Aqui você pode adicionar a lógica para o que acontece quando a nave colide com a estrela
            // Por exemplo, aumentar a pontuação, destruir a estrela, etc.
            Debug.Log("Nave colidiu com a estrela!");
            GetComponent<SpriteRenderer>().enabled = false; // Esconde a estrela
            Destroy(gameObject, 0.8f); // Destroi a estrela após a colisão
            collision.GetComponent<Nave>().CountStars(); // Chama o método para adicionar pontuação na nave
            collect_sound.Play(); // Toca o som de coleta
        }
    }

}
