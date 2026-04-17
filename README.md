# Mission Disarm — Design System

**War Trivia · Landmine Cleanup · UI Spec**  
*Elisabeth Boylan Ltd. · v1.0 · April 2026*

---

## Live Site

Deployed at: `https://mission-disarm-design-system.vercel.app`

---

## What's in this repo

| File | Purpose |
|------|---------|
| `index.html` | The full design system — self-contained, single-page |
| `vercel.json` | Vercel deployment config with caching and security headers |

## Full Asset Package

The complete design system is also available in the following formats (see releases or `/assets`):

| File | Format | Use for |
|------|--------|---------|
| `MissionDisarm_DesignSystem.html` | HTML | Browser / shareable URL |
| `MissionDisarm_DesignSystem.pdf` | PDF | Print / portfolio |
| `MissionDisarm_DesignSystem.docx` | Word | Client handoff / Google Drive |
| `MissionDisarm_DesignSystem.md` | Markdown | Repo docs / GitHub wiki |
| `variables.uss` | Unity USS | UI Toolkit stylesheet tokens |
| `MissionDisarmTheme.cs` | C# | Unity ScriptableObject token wrapper |

---

## Design Tokens

### Colors
| Token | Hex | Usage |
|-------|-----|-------|
| `color-black` | `#0A0A0A` | Primary background |
| `color-pink` | `#FF2D78` | Accent, CTA, glow, danger |
| `color-teal` | `#4ECDC4` | Correct state, HUD labels |
| `color-sand` | `#C8B89A` | Rover, neutral, body text |
| `color-surface` | `#111111` | Cards, panels |

### Typography
- **Display:** Robotech GP (licensed) / Orbitron fallback — 48–64px, 900 weight
- **UI / Headings:** Orbitron (Google Fonts) — 8–24px
- **Body / Flavor:** Courier New (system) — 11–13px

> Orbitron is loaded from Google Fonts CDN at runtime. The site requires an internet connection to render the correct typeface. Fallback is `monospace`.

---

## Unity Integration

Drop `variables.uss` into `Assets/UI/Styles/` and import it in your UI Toolkit stylesheets:

```css
@import url("variables.uss");

.my-button {
  border-color: var(--color-pink);
  color: var(--color-pink);
}
```

Add `MissionDisarmTheme.cs` to your project and create a Theme asset via  
**Assets → Create → Mission Disarm → Theme**.

---

## Deploy to Vercel

### One-click (recommended)
1. Fork or push this repo to GitHub
2. Go to [vercel.com/new](https://vercel.com/new)
3. Import the GitHub repo
4. Vercel auto-detects static HTML — no build settings needed
5. Click **Deploy**

### Via Vercel CLI
```bash
npm i -g vercel
cd mission-disarm-design-system
vercel
```

### Custom domain
In Vercel dashboard → Project → Settings → Domains  
Add: `design.missiondisarm.com` (or your preferred subdomain)

---

## Local Preview

No build step required. Just open `index.html` in a browser:

```bash
# macOS
open index.html

# or serve locally
npx serve .
# → http://localhost:3000
```

---

## About

**Mission Disarm** is a Unity game about disarming the violent mind — featuring a 3D landmine cleanup rover game and a War Trivia challenge.

**Elisabeth Boylan Ltd.**  
[elisabethboylan.com](https://elisabethboylan.com) · [Substack](https://egboylan.substack.com) · [GitHub](https://github.com/elisabethboylan)

---

*Design system built with HTML/CSS · DOCX via docx.js · PDF via ReportLab · Unity assets hand-coded*
