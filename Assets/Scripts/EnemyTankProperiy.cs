using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTankProperiy : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent agent;
    public float moveSpeed;
    public float rotationSpeed;
    public float damage;
    public float health;

    [SerializeField]
    private Slider healthSlider;

    void Start()
    {
        agent = this.GetComponent<UnityEngine.AI.NavMeshAgent>();
        
    }

    void Update()
    {
    
        healthSlider.value = health;
        if (health <= 0)
        {
            Destroy(gameObject);
        }


    }

   
}
