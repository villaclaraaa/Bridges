using UnityEngine;

public class CircleContainer : MonoBehaviour
{
	private SpriteRenderer _renderer;

	// Uncomment this to start working script.
	//private void Awake()
	//{
	//	_renderer = GetComponent<SpriteRenderer>();
	//	var number = GetComponentInParent<Number>();
	//	number.OnIsAllowedToStopDragChanged += SetColorIfAllowedToDrop;
	//}

	private void SetColorIfAllowedToDrop(bool isAllowedToDrop)
	{
		_renderer.color = isAllowedToDrop
			? new Color32(60, 143, 79, 255)
			: new Color32(255, 0, 0, 255);
	}
}
