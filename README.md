# Typst Material You
🎨 Utility to parse material you theme for typst

## Usage Guide
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

## Sample Preview
### Light M3 Palette
![Light Palette](https://ucarecdn.com/b2367c79-7209-4193-8e96-1d59974f1b31/typstm3light.jpeg)

### Dark M3 Palette
![Dark Palette](https://ucarecdn.com/8ad3887f-443e-40de-b6cf-b779f19e8d13/typstm3dark.jpeg)
