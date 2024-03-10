#import "m3.typ": m3light, m3dark
#set text(size: 12pt, font: "Georgia")

#let m3box(color, name) = [
  #box(width: 32pt, height: 32pt, fill: color, stroke: 2pt, radius: 2pt, baseline: 30%)
  #h(8pt) #text(name)
]

= Color Preview
== Light M3 Palette
#table(
  columns: (1fr, 1fr),
  stroke: 0pt,

  [#m3box(m3light.primary, "Primary")],
  [#m3box(m3light.onPrimary, "On Primary")],
  [#m3box(m3light.primaryContainer, "Primary Container")],
  [#m3box(m3light.onPrimaryContainer, "On Primary Container")],

  [#v(12pt)],[],
  [#m3box(m3light.secondary, "Secondary")],
  [#m3box(m3light.onSecondary, "On Secondary")],
  [#m3box(m3light.secondaryContainer, "Secondary Container")],
  [#m3box(m3light.onSecondaryContainer, "On Secondary Container")],

  [#v(12pt)],[],
  [#m3box(m3light.tertiary, "Tertiary")],
  [#m3box(m3light.onTertiary, "On Tertiary")],
  [#m3box(m3light.tertiaryContainer, "Tertiary Container")],
  [#m3box(m3light.onTertiaryContainer, "On Tertiary Container")],

  [#v(12pt)],[],
  [#m3box(m3light.error, "Error")],
  [#m3box(m3light.onError, "On Error")],
  [#m3box(m3light.errorContainer, "Error Container")],
  [#m3box(m3light.onErrorContainer, "On Error Container")],

  [#v(12pt)],[],
  [#m3box(m3light.background, "Background")],
  [#m3box(m3light.onBackground, "On background")],
)

#pagebreak()
== Dark M3 Palette
#table(
  columns: (1fr, 1fr),
  stroke: 0pt,

  [#m3box(m3dark.primary, "Primary")],
  [#m3box(m3dark.onPrimary, "On Primary")],
  [#m3box(m3dark.primaryContainer, "Primary Container")],
  [#m3box(m3dark.onPrimaryContainer, "On Primary Container")],

  [#v(12pt)],[],
  [#m3box(m3dark.secondary, "Secondary")],
  [#m3box(m3dark.onSecondary, "On Secondary")],
  [#m3box(m3dark.secondaryContainer, "Secondary Container")],
  [#m3box(m3dark.onSecondaryContainer, "On Secondary Container")],

  [#v(12pt)],[],
  [#m3box(m3dark.tertiary, "Tertiary")],
  [#m3box(m3dark.onTertiary, "On Tertiary")],
  [#m3box(m3dark.tertiaryContainer, "Tertiary Container")],
  [#m3box(m3dark.onTertiaryContainer, "On Tertiary Container")],

  [#v(12pt)],[],
  [#m3box(m3dark.error, "Error")],
  [#m3box(m3dark.onError, "On Error")],
  [#m3box(m3dark.errorContainer, "Error Container")],
  [#m3box(m3dark.onErrorContainer, "On Error Container")],

  [#v(12pt)],[],
  [#m3box(m3dark.background, "Background")],
  [#m3box(m3dark.onBackground, "On background")],
)
