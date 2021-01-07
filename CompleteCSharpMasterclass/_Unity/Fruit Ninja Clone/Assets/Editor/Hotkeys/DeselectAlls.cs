using UnityEditor;
using UnityEngine;

namespace Editor.Hotkeys
{
    public static class DeselectAlls {

        private static GameObject _previousSelection;

        [MenuItem("Edit/Deselect All &e", false, -101)]
        public static void DeselectEverything() {
            if(Selection.activeGameObject != null) {
                _previousSelection = Selection.activeGameObject;
                Selection.activeGameObject = null;
            } else {
                Selection.activeGameObject = _previousSelection;
            }
        }
    }
}