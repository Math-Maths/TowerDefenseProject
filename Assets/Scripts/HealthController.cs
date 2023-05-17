using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int maxHealth = 20;
    public int currentHealth;
    public GameObject ActiveCanvas;
    public float DelayGameOver = 1.5f;
    public float DelayTowerDestroy = 3.0f;
    [SerializeField] private LifeBarControl lifeBar;
    
    //Controle da animação da camera ao morrer
    public GameObject mainCamera;
    public Animator animator;
    

    private void Start()
    {
        currentHealth = maxHealth;
        ScoreControl.Score = 0;

        lifeBar.LifeBarChange(currentHealth, maxHealth);
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        lifeBar.LifeBarChange(currentHealth, maxHealth);
        
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            // Chama a tela de GameOver com base no tempo definido
            Invoke("ActiveGameOver", DelayGameOver);
            // Se a vida chegar a 0, o projectile shooter é destruído 
            Invoke("DestroyObject", DelayTowerDestroy);
            //Chama a animação de FadeOut da câmera
            Invoke("CameraZoomIn", .5f);
            
        }
    }

    void DestroyObject()
    {
        Destroy(gameObject);
    }
    void ActiveGameOver()
    {
        ActiveCanvas.SetActive(true);
    }

    //Método para afastar a câmera no eixo Z local
    void CameraZoomIn()
    {
        animator.SetTrigger("CameraFadeIn");
    }

    public void Heal(int amount)
    {
        currentHealth += amount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Quando o projectile shooter colide com um inimigo, chama o método TakeDamage do script HealthController
            TakeDamage(5);
        }
    }
}