using UnityEngine;

/// <summary>
/// Mission Disarm Design System — Token ScriptableObject
/// Create via: Assets > Create > Mission Disarm > Theme
/// Assign to UIManager and reference throughout UI Toolkit documents.
/// </summary>
[CreateAssetMenu(fileName = "MissionDisarmTheme", menuName = "Mission Disarm/Theme", order = 1)]
public class MissionDisarmTheme : ScriptableObject
{
    [Header("─── COLORS ───────────────────────")]
    public Color colorBlack      = new Color(0.039f, 0.039f, 0.039f, 1f);   // #0A0A0A
    public Color colorPink       = new Color(1.000f, 0.176f, 0.471f, 1f);   // #FF2D78
    public Color colorTeal       = new Color(0.306f, 0.804f, 0.769f, 1f);   // #4ECDC4
    public Color colorSand       = new Color(0.784f, 0.722f, 0.604f, 1f);   // #C8B89A
    public Color colorSurface    = new Color(0.067f, 0.067f, 0.067f, 1f);   // #111111
    public Color colorSurface2   = new Color(0.102f, 0.102f, 0.102f, 1f);   // #1A1A1A
    public Color colorWhite      = new Color(0.910f, 0.910f, 0.878f, 1f);   // #E8E8E0
    public Color colorMuted      = new Color(0.910f, 0.910f, 0.878f, 0.5f); // #E8E8E0 @ 50%

    [Header("─── ALPHA VARIANTS ─────────────────")]
    public Color colorPinkDim    = new Color(1.000f, 0.176f, 0.471f, 0.15f); // Pink @ 15%
    public Color colorPinkGlow   = new Color(1.000f, 0.176f, 0.471f, 0.35f); // Pink @ 35%
    public Color colorTealDim    = new Color(0.306f, 0.804f, 0.769f, 0.10f); // Teal @ 10%
    public Color colorBorderPink = new Color(1.000f, 0.176f, 0.471f, 0.30f); // Pink border
    public Color colorBorderTeal = new Color(0.306f, 0.804f, 0.769f, 0.30f); // Teal border
    public Color colorFaint      = new Color(1.000f, 1.000f, 1.000f, 0.06f); // Surface border

    [Header("─── SPACING (px) ─────────────────")]
    public float spaceXS  =  4f;
    public float spaceSM  =  8f;
    public float spaceMD  = 12f;
    public float spaceLG  = 16f;
    public float spaceXL  = 24f;
    public float space2XL = 32f;
    public float space3XL = 48f;

    [Header("─── TYPOGRAPHY (pt) ──────────────")]
    public float sizeDisplay  = 48f;
    public float sizeHeading  = 20f;
    public float sizeQuestion = 15f;
    public float sizeLabel    =  9f;
    public float sizeBody     = 11f;

    [Header("─── MOTION (seconds) ─────────────")]
    public float durationInstant  = 0.08f;
    public float durationQuick    = 0.15f;
    public float durationStandard = 0.30f;
    public float durationDramatic = 0.60f;
    public float durationPulse    = 2.00f;

    [Header("─── BLOOM / URP ─────────────────")]
    [Range(0f, 2f)] public float bloomIntensity = 1.0f;
    [Range(0f, 1f)] public float bloomThreshold = 0.85f;
    [Range(0f, 1f)] public float bloomScatter   = 0.50f;
    public Color bloomTint = new Color(1f, 0.176f, 0.471f, 1f); // #FF2D78

    // ─── CONVENIENCE GETTERS ───────────────────────────────────────────────

    /// <summary>Returns the correct feedback color for a trivia answer result.</summary>
    public Color GetAnswerColor(bool isCorrect) => isCorrect ? colorTeal : colorPink;

    /// <summary>Returns the correct border color for a panel state.</summary>
    public Color GetFeedbackBorder(bool isCorrect) => isCorrect ? colorBorderTeal : colorBorderPink;

    /// <summary>Returns progress fill color. Complete = teal, in-progress = pink.</summary>
    public Color GetProgressColor(float normalizedProgress) =>
        normalizedProgress >= 1f ? colorTeal : colorPink;
}
