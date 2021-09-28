using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerShip : MonoBehaviour
{
	#region SerializeFields
	[SerializeField]
	[Tooltip("How fast the ship moves")]
	private float _moveSpeed = 3f;
	#endregion

	#region Components
	private Rigidbody2D _rb2d;
	#endregion

	#region Private Variables
	private Vector2 _moveValue;
	#endregion

	#region Input Actions
	// These methods are called when their corresponding input actions are triggered by the player input component
	void OnMove(InputValue value)
	{
		_moveValue = value.Get<Vector2>();
		if(_moveValue.magnitude > 1f)
		{
			_moveValue = _moveValue.normalized;
		}
	}

	void OnShoot(InputValue value)
	{
		if(value.isPressed)
		{
			Debug.Log("SHOOT STARTED");
		}
		else
		{
			Debug.Log("SHOOT ENDED");
		}
	}

	void OnEquipWeapon1()
	{
		Debug.Log("Weapon 1 equipped");
	}

	void OnEquipWeapon2()
	{
		Debug.Log("Weapon 2 equipped");
	}

	void OnEquipWeapon3()
	{
		Debug.Log("Weapon 3 equipped");
	}
	#endregion

	#region MonoBehaviour
	// Start is called before the first frame update
	void Start()
    {
		_rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

	// FixedUpdate is called a fixed number of times per second, which is good for physics updates
	void FixedUpdate()
	{
		if(_rb2d)
		{
			_rb2d.velocity = _moveValue * _moveSpeed;
		}
	}
	#endregion
}
