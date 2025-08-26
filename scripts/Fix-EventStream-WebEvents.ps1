Param(
  [string]$Root = 'C:\Users\Intel\Documents\GitHub\RobloxWebsite-2013-\Assemblies\Events\Roblox.EventStream.WebEvents'
)

Write-Host "Fixing files under: $Root"
# Find .cs files but exclude obj/ and bin/ generated outputs
$files = Get-ChildItem $Root -Recurse -Filter *.cs -File | Where-Object {
  $_.FullName -notmatch "\\obj\\" -and $_.FullName -notmatch "\\bin\\"
}
foreach ($f in $files) {
  $path = $f.FullName
  $text = Get-Content -LiteralPath $path -Raw
  $orig = $text
  # Fix wrong namespaces
  $text = $text -replace 'namespace\s+Roblox\.EventStream\.WebEvents\.Eventspublic\s*\{','namespace Roblox.EventStream.WebEvents.Events {'
  $text = $text -replace 'namespace\s+Roblox\.EventStream\.WebEventspublic\s*\{','namespace Roblox.EventStream.WebEvents {'

  # Normalize malformed using lines that lost the 'using' keyword
  $text = $text -replace '(?m)^(\s*)(Roblox\.EventStream\.WebEvents\.EventArgs)\s*;','$1using $2;'
  $text = $text -replace '(?m)^(\s*)(Roblox\.EventStream\.WebEvents)\s*;','$1using $2;'
  $text = $text -replace '(?m)^(\s*)(Roblox\.EventStream)\s*;','$1using $2;'

  # Replace Platform usings with correct ones
  $text = $text -replace 'using\s+Roblox\.Platform\.EventStream\.WebEvents\.EventArgs\s*;','using Roblox.EventStream.WebEvents.EventArgs;'
  $text = $text -replace 'using\s+Roblox\.Platform\.EventStream(?=[\s;])','using Roblox.EventStream'

  # Ensure base usings when common BCL types used
  if ($text -match '\b(DateTime|Guid|Func<|IReadOnlyCollection<|List<)') {
    if ($text -notmatch '(?m)^\s*using\s+System\s*;') { $text = "using System;`r`n" + $text }
    if ($text -match '\b(IReadOnlyCollection|List)\s*<') {
      if ($text -notmatch '(?m)^\s*using\s+System\.Collections\.Generic\s*;') {
        $text = $text -replace '(?ms)^(\s*(?:using\s+[^;]+;\s*)+)', "$1using System.Collections.Generic;`r`n"
        if ($text -notmatch '(?m)^\s*using\s+System\.Collections\.Generic\s*;') { $text = "using System.Collections.Generic;`r`n" + $text }
      }
    }
  }

  # Always ensure System and System.Collections.Generic usings exist to avoid missing BCL symbols
  if ($text -notmatch '(?m)^\s*using\s+System\s*;') {
    $text = $text -replace '(?ms)^(\s*(?:using\s+[^;]+;\s*)+)', "$1using System;`r`n"
    if ($text -notmatch '(?m)^\s*using\s+System\s*;') { $text = "using System;`r`n" + $text }
  }
  if ($text -notmatch '(?m)^\s*using\s+System\.Collections\.Generic\s*;') {
    $text = $text -replace '(?ms)^(\s*(?:using\s+[^;]+;\s*)+)', "$1using System.Collections.Generic;`r`n"
    if ($text -notmatch '(?m)^\s*using\s+System\.Collections\.Generic\s*;') { $text = "using System.Collections.Generic;`r`n" + $text }
  }

  # Ensure DescriptionAttribute
  if ($text -match '(\[Description\(|\bDescriptionAttribute\b)') {
    if ($text -notmatch '(?m)^\s*using\s+System\.ComponentModel\s*;') {
      $text = $text -replace '(?ms)^(\s*(?:using\s+[^;]+;\s*)+)', "$1using System.ComponentModel;`r`n"
      if ($text -notmatch '(?m)^\s*using\s+System\.ComponentModel\s*;') { $text = "using System.ComponentModel;`r`n" + $text }
    }
  }

  # Ensure Roblox.Time for UtcInstant
  if ($text -match '\bUtcInstant\b' -and $text -notmatch '(?m)^\s*using\s+Roblox\.Time\s*;') {
    $text = $text -replace '(?ms)^(\s*(?:using\s+[^;]+;\s*)+)', "$1using Roblox.Time;`r`n"
    if ($text -notmatch '(?m)^\s*using\s+Roblox\.Time\s*;') { $text = "using Roblox.Time;`r`n" + $text }
  }

  # Ensure project usings
  if ($text -match '\b(WebEventBase|BufferedEventBase|IEventStreamer|BufferedEventStreamer|EventBase|EventTarget|BasicEventArgs)\b' -and $text -notmatch '(?m)^\s*using\s+Roblox\.EventStream\s*;') {
    $text = $text -replace '(?ms)^(\s*(?:using\s+[^;]+;\s*)+)', "$1using Roblox.EventStream;`r`n"
    if ($text -notmatch '(?m)^\s*using\s+Roblox\.EventStream\s*;') { $text = "using Roblox.EventStream;`r`n" + $text }
  }
  if ($text -match '\b(WebEventBase|WebEventArgs|BasicEventArgs)\b' -and $text -notmatch '(?m)^\s*using\s+Roblox\.EventStream\.WebEvents\s*;') {
    $text = $text -replace '(?ms)^(\s*(?:using\s+[^;]+;\s*)+)', "$1using Roblox.EventStream.WebEvents;`r`n"
    if ($text -notmatch '(?m)^\s*using\s+Roblox\.EventStream\.WebEvents\s*;') { $text = "using Roblox.EventStream.WebEvents;`r`n" + $text }
  }
  if ($text -match '\b\w+EventArgs\b' -and $text -notmatch '(?m)^\s*using\s+Roblox\.EventStream\.WebEvents\.EventArgs\s*;') {
    $text = $text -replace '(?ms)^(\s*(?:using\s+[^;]+;\s*)+)', "$1using Roblox.EventStream.WebEvents.EventArgs;`r`n"
    if ($text -notmatch '(?m)^\s*using\s+Roblox\.EventStream\.WebEvents\.EventArgs\s*;') { $text = "using Roblox.EventStream.WebEvents.EventArgs;`r`n" + $text }
  }

  # Standardize EventStreamer mentions to interface in params and base type lists
  $text = $text -replace '(?<![A-Za-z0-9_])EventStreamer(?![A-Za-z0-9_])','IEventStreamer'

  # Make top-level class/enum/struct public if not already
  $text = $text -replace '(?m)^(\s*)(abstract\s+)?class\s+(\w+)','${1}public ${2}class ${3}'
  $text = $text -replace '(?m)^(\s*)enum\s+(\w+)','${1}public enum ${2}'
  $text = $text -replace '(?m)^(\s*)struct\s+(\w+)','${1}public struct ${2}'

  if ($text -ne $orig) {
    Set-Content -LiteralPath $path -Value $text -Encoding UTF8
    Write-Host "Updated: $path"
  }
}
Write-Host "Done."
