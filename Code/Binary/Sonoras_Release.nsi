!define /date MyTIMESTAMP "%Y-%m-%d@%H-%M"
Name "Sonoras"
OutFile "Sonoras_Setup-${MyTIMESTAMP}.exe"
InstallDir "$DESKTOP\Sonoras"

RequestExecutionLevel user

Page Directory
Page Instfiles
;--------------------------------
Section "Files" 
  CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r ".\Release\net9.0\*.dll"
  File /r ".\Release\net9.0\*.json"
  
  File /r ".\Release\net9.0-windows\*.dll"
  File /r ".\Release\net9.0-windows\*.exe"
  File /r ".\Release\net9.0-windows\*.json"
  File /r ".\Release\net9.0-windows\*.toml"
  
SectionEnd ; end the section
