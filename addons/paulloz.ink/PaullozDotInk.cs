#if TOOLS
using Godot;
using Godot.Collections;
using System;

[Tool]
public class PaullozDotInk : EditorPlugin
{
    private const String addonBasePath = "res://addons/paulloz.ink";

    private NodePath customTypeScriptPath = $"{addonBasePath}/InkStory.cs";
    private NodePath customTypeIconPath = $"{addonBasePath}/icon.svg";

    public override void _EnterTree()
    {
        // Custom types
        AddCustomType("Ink Story", "Node", GD.Load<Script>(customTypeScriptPath), GD.Load<Texture>(customTypeIconPath));

    }

    public override void _ExitTree()
    {
        // Custom types
        RemoveCustomType("Ink Story");
    }
}
#endif
