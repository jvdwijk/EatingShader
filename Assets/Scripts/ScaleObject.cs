using UnityEngine;

public class ScaleObject : MonoBehaviour
{
	private Material _material;
	private float _size;

	private void Start()
	{
		_material = gameObject.GetComponent<Renderer>().material;
		_size = 0.1f;
		ChangeSize();
	}

	private void Update()
	{
		_size = _size - 0.0003f;
		ChangeSize();
	}
    private void OnTriggerStay (Collider other)
    {
	    if (other.CompareTag("Player") || !Input.GetKeyDown(KeyCode.Space)) return;
	    _size = _size + 0.1f;
	    ChangeSize();
    }

	private void ChangeSize()
	{
		_material.SetFloat("_Amount", _size);
	}
}