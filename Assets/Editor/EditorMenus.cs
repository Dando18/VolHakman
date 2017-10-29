using UnityEditor;

static class EditorMenus
{
    [MenuItem("Tools/Toggle Inspector Lock %1")]  // Ctrl - L
    static void ToggleInspectorLock()
    {
        ActiveEditorTracker.sharedTracker.isLocked = !ActiveEditorTracker.sharedTracker.isLocked;
        ActiveEditorTracker.sharedTracker.ForceRebuild();
    }
}
