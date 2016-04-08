using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class GameManager : MonoBehaviour {

  private VRInteractiveItem[] m_InteractiveItems;
  private VRInput m_VRInput;

  [SerializeField] GameObject m_CameraContainer;
  [SerializeField] float m_MovementSpeed = 3f;

	// Use this for initialization
	void Start () {
    SetupGaze();
    SetupMovement();
	}

  void SetupGaze() {
    // Find items that can be interacted with via gaze
    m_InteractiveItems = GameObject.FindObjectsOfType<VRInteractiveItem>();

    // Subscribe to appropriate events on each interactable item
    for(int i = 0; i < m_InteractiveItems.Length; i++) {
      var item = m_InteractiveItems[i];
      item.OnOver += delegate() { this.OnItemOver(item); };
      item.OnOut += delegate() { this.OnItemOut(item); };
      // Also subscribeable: OnDoubleClick, OnClick, OnDown, OnUp

    }
  }

  void SetupMovement() {
    // Find input manager
    m_VRInput = GameObject.FindObjectOfType<VRInput>();

    // This action is invoked on every single frame
    m_VRInput.OnSwipe += this.OnSwipe;
  }

  void OnItemOver(VRInteractiveItem item) {
    // Scale item down to half it's normal size
    item.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
  }

  void OnItemOut(VRInteractiveItem item) {
    // Scale item back up to full size
    item.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
  }

  void OnSwipe(VRInput.SwipeDirection direction) {
    // Only do something when we have a swipe
    if(direction != VRInput.SwipeDirection.NONE) {
      switch(direction) {
        case VRInput.SwipeDirection.LEFT:
          m_CameraContainer.transform.Translate(0, 0, m_MovementSpeed);
          break;
        case VRInput.SwipeDirection.RIGHT:
          m_CameraContainer.transform.Translate(0, 0, m_MovementSpeed * -1);
          break;
        case VRInput.SwipeDirection.UP:
          m_CameraContainer.transform.Translate(m_MovementSpeed * -1, 0, 0);
          break;
        case VRInput.SwipeDirection.DOWN:
          m_CameraContainer.transform.Translate(m_MovementSpeed, 0, 0);
          break;
      }
    }
  }
}
