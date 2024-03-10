#import "m3.typ": m3light, m3dark

#set page(paper:"a4", margin: 32pt)

#let m3box(color) = box(width: 32pt, height: 32pt, fill: color, radius: 2pt, stroke: 1pt)

$
overbracket(
#m3box(m3light.primary)
#m3box(m3light.onPrimary)
#m3box(m3light.primaryContainer)
#m3box(m3light.onPrimaryContainer),
  "Light Primary"
)

#h(8pt)
overbracket(
#m3box(m3light.secondary)
#m3box(m3light.onSecondary)
#m3box(m3light.secondaryContainer)
#m3box(m3light.onSecondaryContainer),
  "Light Secondary"
)

#h(8pt)
overbracket(
#m3box(m3light.tertiary)
#m3box(m3light.onTertiary)
#m3box(m3light.tertiaryContainer)
#m3box(m3light.tertiaryContainer),
  "Light Tertiary"
)

#h(8pt)
overbracket(
#m3box(m3light.background)
#m3box(m3light.onBackground),
  "Light Background"
)
$

// -- //

$
underbracket(
  #m3box(m3dark.primary)
  #m3box(m3dark.onPrimary)
  #m3box(m3dark.primaryContainer)
  #m3box(m3dark.onPrimaryContainer),
  "Dark Primary"
)

#h(8pt)
underbracket(
  #m3box(m3dark.secondary)
  #m3box(m3dark.onSecondary)
  #m3box(m3dark.secondaryContainer)
  #m3box(m3dark.onSecondaryContainer),
  "Dark Secondary"
)

#h(8pt)
underbracket(
  #m3box(m3dark.tertiary)
  #m3box(m3dark.onTertiary)
  #m3box(m3dark.tertiaryContainer)
  #m3box(m3dark.tertiaryContainer),
  "Dark Tertiary"
)

#h(8pt)
underbracket(
  #m3box(m3dark.background)
  #m3box(m3dark.onBackground),
  "Dark Background"
)
$
