# Mission Disarm — Design System v1.0
**War Trivia · Landmine Cleanup · UI Spec**  
Elisabeth Boylan Ltd. · April 2026

---

## 01 · Color System

| Token | Hex | RGB | Usage |
|-------|-----|-----|-------|
| `color-black` | `#0A0A0A` | 10, 10, 10 | Primary background |
| `color-pink` | `#FF2D78` | 255, 45, 120 | Primary accent, CTAs, glow, danger |
| `color-teal` | `#4ECDC4` | 78, 205, 196 | Secondary, correct state, labels |
| `color-sand` | `#C8B89A` | 200, 184, 154 | HUD, rover, terrain neutral |
| `color-surface` | `#111111` | 17, 17, 17 | Cards, panels |
| `color-surface-2` | `#1A1A1A` | 26, 26, 26 | Elevated panels |

### Color Usage Rules
- **Neon Pink** → Logo glow · CTAs · wrong answer · danger · progress bar
- **Teal** → Correct answers · HUD labels · section headers · success
- **Sand** → Rover vehicle · neutral body text · terrain elements
- **Black** → All backgrounds, including tactical grid overlay base
- Never use pure white (`#FFFFFF`) — use `#E8E8E0` (warm off-white) for text

### Alpha Variants
```
pink-dim:    rgba(255, 45, 120, 0.15)   — button hover fill
pink-glow:   rgba(255, 45, 120, 0.35)   — text-shadow, bloom
teal-dim:    rgba(78, 205, 196, 0.10)   — correct answer fill
border-pink: rgba(255, 45, 120, 0.30)   — default answer border
border-teal: rgba(78, 205, 196, 0.30)   — correct/HUD borders
faint:       rgba(255, 255, 255, 0.06)  — surface borders
```

---

## 02 · Typography

### Font Families
| Role | Font | Fallback | Source |
|------|------|----------|--------|
| Display / Logo | Robotech GP | Orbitron | Commercial — license required |
| UI / Headings | Orbitron | monospace | Google Fonts |
| Body / Flavor | Courier New | monospace | System |

> **Note:** Robotech GP is a commercial display face. Acquire the .ttf desktop/game license before embedding in a Unity build. Orbitron is the approved substitute and secondary UI font.

### Type Scale
| Style | Font | Size | Weight | Letter-spacing | Color |
|-------|------|------|--------|----------------|-------|
| Display | Robotech GP | 48–64px | 900 | 3px | `color-pink` + glow |
| Heading | Orbitron | 18–24px | 700 | 2px | `#E8E8E0` |
| Question | Orbitron | 14–16px | 400 | 0 | `rgba(255,255,255,0.85)` |
| Label/Cap | Orbitron | 8–10px | 400 | 4px | `color-pink` or `color-teal` |
| Body/Flavor | Courier New | 11–13px | 400 | 1px | `rgba(255,255,255,0.55)` |

### Display Glow Effect
```css
text-shadow: 0 0 12px #FF2D78, 0 0 30px rgba(255,45,120,0.35);
```

---

## 03 · Core Components

### Buttons

**Primary (Pink)**
```css
background: transparent;
border: 1px solid #FF2D78;
color: #FF2D78;
font-family: Orbitron;
font-size: 9px;
letter-spacing: 3px;
text-transform: uppercase;
padding: 11px 22px;
/* Hover */
background: rgba(255,45,120,0.15);
box-shadow: 0 0 12px rgba(255,45,120,0.35);
```

**Secondary (Teal)**
```css
border: 1px solid #4ECDC4;
color: #4ECDC4;
/* Same structure as Primary */
```

**Ghost (Inactive)**
```css
border: 1px solid rgba(255,255,255,0.12);
color: rgba(255,255,255,0.35);
```

---

### Answer Choice Buttons
```css
/* Default */
background: rgba(255,45,120,0.06);
border: 1px solid rgba(255,45,120,0.30);
color: rgba(255,255,255,0.70);
padding: 13px 14px;
text-align: left;

/* Correct */
border-color: #4ECDC4;
color: #4ECDC4;
background: rgba(78,205,196,0.10);

/* Wrong */
border-color: rgba(255,45,120,0.30);
color: rgba(255,45,120,0.50);
text-decoration: line-through;
opacity: 0.6;
```

---

### Progress Bar
```css
/* Track */
height: 2px;
background: rgba(255,255,255,0.08);

/* Fill */
background: #FF2D78;
box-shadow: 0 0 8px rgba(255,45,120,0.50);
/* Complete state fill */
background: #4ECDC4;
box-shadow: 0 0 8px rgba(78,205,196,0.50);
```

---

### Feedback Panels

**Correct — Target Neutralized**
```css
border: 1px solid rgba(78,205,196,0.40);
background: rgba(78,205,196,0.04);
padding: 14px 16px;
```
Status label: `color: #4ECDC4; font-size: 9px; letter-spacing: 4px; text-transform: uppercase;`

**Wrong — Mission Compromised**
```css
border: 1px solid rgba(255,45,120,0.40);
background: rgba(255,45,120,0.04);
```
Status label: `color: #FF2D78;`

---

### HUD Stats (Landmine Game)
```css
/* Stat container */
display: inline-flex;
flex-direction: column;
align-items: center;
padding: 8px 14px;
border: 1px solid rgba(78,205,196,0.30);

/* Value */
font-size: 20px;
font-weight: 900;
color: #E8E8E0;

/* Label */
font-size: 7px;
letter-spacing: 3px;
color: #4ECDC4;
text-transform: uppercase;
margin-top: 4px;
```

---

### Intel Panel (Landmine Game)
```css
border: 1px solid rgba(78,205,196,0.30);
padding: 14px;
/* Title */
font-size: 13px;
letter-spacing: 4px;
color: #4ECDC4;
/* Body */
font-family: 'Courier New';
font-size: 10px;
color: #FF2D78;
```

---

## 04 · Spacing Scale

| Token | Value | Usage |
|-------|-------|-------|
| `space-xs` | 4px | Icon gaps, tight pairs |
| `space-sm` | 8px | Internal component spacing |
| `space-md` | 12px | Component internals |
| `space-lg` | 16px | Between components |
| `space-xl` | 24px | Section padding |
| `space-2xl` | 32px | Large section gaps |
| `space-3xl` | 48px | Page-level padding |

Base unit: **4px**

---

## 05 · Motion Tokens

| Token | Value | Usage |
|-------|-------|-------|
| `duration-instant` | 80ms ease-out | Button press, icon tap |
| `duration-quick` | 150ms ease-out | Answer reveal, hover |
| `duration-standard` | 300ms ease-in-out | Panel slide, progress fill |
| `duration-dramatic` | 600ms cubic-bezier(.22,1,.36,1) | Screen transitions, score pop |
| `duration-pulse` | 2s ease-in-out infinite alternate | Logo glow, active landmine |

### Glow Pulse Keyframe
```css
@keyframes glowPulse {
  from { text-shadow: 0 0 8px rgba(255,45,120,0.3); }
  to   { text-shadow: 0 0 24px rgba(255,45,120,0.8), 0 0 48px rgba(255,45,120,0.4); }
}
```

---

## 06 · Visual Effects & Texture

### Tactical Grid Overlay
```css
background-image:
  linear-gradient(rgba(255,45,120,0.04) 1px, transparent 1px),
  linear-gradient(90deg, rgba(255,45,120,0.04) 1px, transparent 1px);
background-size: 32px 32px;
```
Apply to all full-bleed backgrounds and major panels.

### Neon Glow — Pink (Text)
```css
text-shadow: 0 0 12px #FF2D78, 0 0 24px rgba(255,45,120,0.35);
```

### Neon Glow — Teal (Border)
```css
box-shadow: inset 0 0 10px rgba(78,205,196,0.15), 0 0 10px rgba(78,205,196,0.10);
```

### Unity URP Post-Processing (Bloom)
- Bloom Intensity: 0.8–1.2
- Threshold: 0.85 (only neon pink emissive layer blooms)
- Scatter: 0.5
- Tint: `#FF2D78`

---

## 07 · Microcopy Voice & Tone

### ✅ Use — Military Ops Register
```
CORRECT — TARGET NEUTRALIZED
NEGATIVE — MISSION COMPROMISED
NEXT QUESTION
OPERATION CLEAN UP
UNDERSTOOD?
INTEL
WAR TRIVIA CHALLENGE
DISARMING THE VIOLENT MIND
LANDMINES: [n]
```

### ❌ Avoid — Consumer App Tropes
```
Great job! 🎉
Try again!
Click here
Submit answer
Loading...
Play now!
Enter your name
You're doing great!
```

### Tone Principles
1. **Terse** — every word earns its place
2. **Tactical** — ops language, not retail language
3. **All caps for status** — labels and statuses always uppercase
4. **No emoji** — iconography uses custom SVG assets only
5. **Pacifist subtext** — the violence is being dismantled, not celebrated

---

## 08 · Unity Implementation Notes

### USS Variables (variables.uss)
```css
:root {
  --color-black: rgb(10, 10, 10);
  --color-pink: rgb(255, 45, 120);
  --color-teal: rgb(78, 205, 196);
  --color-sand: rgb(200, 184, 154);
  --color-surface: rgb(17, 17, 17);
  --color-white: rgb(232, 232, 224);
  --space-xs: 4px;
  --space-sm: 8px;
  --space-md: 12px;
  --space-lg: 16px;
  --space-xl: 24px;
  --duration-quick: 150ms;
  --duration-standard: 300ms;
}
```

### Font Assets Required
- `Orbitron-Regular.ttf` — Google Fonts (free, SIL OFL)
- `Orbitron-Bold.ttf`
- `Orbitron-ExtraBold.ttf`
- `RobotechGP.ttf` — commercial license required
- Import as TMP Font Assets in Unity, set to Dynamic rendering

### ScriptableObject Token Reference
See `MissionDisarmTheme.cs` for the C# ScriptableObject wrapping all color and spacing tokens.

---

*Mission Disarm Design System v1.0 · Elisabeth Boylan Ltd. · April 2026*  
*elisabethboylan.com · egboylan.substack.com*
