# Typst Material You
🎨 Utility to parse material you theme for typst

## Material You Palettes
### Blue
![](https://ucarecdn.com/9ab07255-6e71-460b-97a0-073ca9b6ccbc/typstm3blue.jpg)

<p align="center">
<a href="https://github.com/Az-21/typst-material-you/blob/main/Sample/blue.typ">Blue M3 Palette ↗️</a>
</p>

### Green
![](https://ucarecdn.com/32edf9f5-c053-4c16-8040-217f408712d7/typstm3green.jpg)

<p align="center">
<a href="https://github.com/Az-21/typst-material-you/blob/main/Sample/green.typ">Green M3 Palette ↗️</a>
</p>

### Purple
![](https://ucarecdn.com/feff05db-cf62-4d2c-a878-96a88e77822c/typstm3purple.jpg)

<p align="center">
<a href="https://github.com/Az-21/typst-material-you/blob/main/Sample/purple.typ">Purple M3 Palette ↗️</a>
</p>

## Usage Guide
The above samples are pre-parsed and ready-to-import in your typst project. If you'd like to generate your custom palette, follow these steps.

### 1. Generate Custom Material You Palette
- Go to https://m3.material.io/theme-builder#/custom
- Set color seeds as per your preference (see left hand panel)
- After previewing colors on the website, export as `.kt` file
  - Click on `Export` button on the top panel
  - Export > Jetpack Compose (Theme.kt)
- Open the downloaded `.zip` archive and copy out `Color.kt` file
  - `Color.kt` can be found in `ui/theme/` folder
- Keep hold of `Color.kt` until the final step

> [!TIP]
> You can rename `Color.kt`. Just preserve the `.kt` extension.

### 2. Install .NET 8.0 Runtime
- Go to https://dotnet.microsoft.com/en-us/download/dotnet/8.0
- Download and install the latest .NET 8.0 **runtime** based on your OS and CPU architecture

### 3. Download Typst Material You
- Download the `.7z` file from https://github.com/Az-21/typst-material-you/releases
- Extract using [7-zip](https://www.7-zip.org/) or [NanaZip](https://github.com/M2Team/NanaZip/releases)
- Copy-paste the `Color.kt` file inside the `Input` folder
- Run `M3Parser.exe`
- Program will generate a ready-to-import color palette in `Output` folder

### 4. Import in Typst Project
```typst
#import "color.typ": m3dark, m3light

#box(width: 32pt, height: 32pt, fill: m3light.primary)
#box(width: 32pt, height: 32pt, fill: m3dark.onTertiary)
```
