using UnityEngine;

[CreateAssetMenu(fileName = "New Projectile", menuName = "EGS/Projectile")]
public class ProjectileSO : ScriptableObject
{
	#region SerializeFields
	[SerializeField]
	[Tooltip("How much damage the projectile deals on impact")]
	private float _damage = 0f;
	[SerializeField]
	[Tooltip("The sprite for the projectile's visuals")]
	private Sprite _sprite;
	#endregion

	#region Properties
	public float Damage { get { return _damage; } }
	public Sprite Sprite { get { return _sprite; } }
	#endregion
}
