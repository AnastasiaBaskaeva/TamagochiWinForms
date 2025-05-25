[Setup]
; Основные настройки
AppName=Tamagochi
AppVersion=1.0
DefaultDirName={autopf}\Tamagochi
SetupIconFile=C:\Users\Admin\VisualStudioProjects\kursach\custom_edited___tamagotchi_customs___lovelitchi_18_05d_icon.ico
UninstallDisplayIcon={app}\Tamagochi.exe
OutputBaseFilename=Tamagochi_Setup

[Files]
; Главный EXE и иконка
Source: "bin\Release\kursach.exe"; DestDir: "{app}"; DestName: "Tamagochi.exe"; Flags: ignoreversion
Source: "custom_edited___tamagotchi_customs___lovelitchi_18_05d_icon.ico"; DestDir: "{app}"; Flags: ignoreversion

; Все необходимые DLL и ресурсы
Source: "bin\Release\*.dll"; DestDir: "{app}"; Flags: ignoreversion

[Icons]
; Ярлыки с правильной иконкой
Name: "{group}\Tamagochi"; Filename: "{app}\Tamagochi.exe"; IconFilename: "{app}\custom_edited___tamagotchi_customs___lovelitchi_18_05d_icon.ico"
Name: "{commondesktop}\Tamagochi"; Filename: "{app}\Tamagochi.exe"; IconFilename: "{app}\custom_edited___tamagotchi_customs___lovelitchi_18_05d_icon.ico"

[Run]
Filename: "{app}\Tamagochi.exe"; Description: "Запустить игру"; Flags: nowait postinstall skipifsilent