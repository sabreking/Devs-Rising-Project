using UnityEngine;
using System.Collections;

public class LivingEntity : MonoBehaviour
{

    protected float _healRate = 0.2f;
    protected float _maxHealth = 100;
    protected bool _isAlive;
    [SerializeField]
    protected float _health = 100;

    public virtual void Start ()
    {
        _isAlive = true;
        StartCoroutine ("Healing");
    }

    public void TakeDamage ( float damage )
    {
        _health -= damage;
        if ( _health <= 0 )
        {
            Die ();
        }
    }

    public void AddHealth (float health)
    {
        if ( _health < 100 && _isAlive )
        {
            _health += health;
        }
    }

    protected void Die ()
    {
        //whatever we want to do here regarding;
        _isAlive = false;
    }

    private IEnumerator Healing ()
    {
        while ( _isAlive )
        {
            if ( _health < 100 )
            {
                _health += _healRate;
            }
            yield return new WaitForSeconds (1);
        }
        yield return null;

    }






}
