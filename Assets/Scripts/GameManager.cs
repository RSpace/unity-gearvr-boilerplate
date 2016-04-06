using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

public class GameManager : MonoBehaviour {

  private VRInteractiveItem[] m_InteractiveItems;

	// Use this for initialization
	void Start () {
    // Find objects that can be interacted with via gaze
    m_InteractiveItems = GameObject.FindObjectsOfType<VRInteractiveItem>();

    // Subscribe to appropriate events on each object
    for(int i = 0; i < m_InteractiveItems.Length; i++) {
      var item = m_InteractiveItems[i];
      item.OnOver += delegate() { this.OnItemOver(item); };
      item.OnOut += delegate() { this.OnItemOut(item); };
      // Also subscribeable: OnDoubleClick, OnClick, OnDown, OnUp

    }
	}

  void OnItemOver(VRInteractiveItem item) {
    // Scale item down to half it's normal size
    item.gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
  }

  void OnItemOut(VRInteractiveItem item) {
    // Scale item back up to full size
    item.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
  }
}
