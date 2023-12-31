; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "������������-�������� ������� �³��� �����"
#define MyAppVersion "1.0.0.0"
#define MyAppExeName "hrdApp.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{AB14E0AA-FFFE-4E6A-A2F2-E59819D6F129}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
DefaultDirName={pf}\hrdApp
DisableProgramGroupPage=yes
OutputDir=E:\������� ������\������ � ����������\2021\���� (����)\HumanResourcesDepartmentAPP\Installer\Setup_Project
OutputBaseFilename=setup
SetupIconFile=E:\������� ������\������ � ����������\2021\���� (����)\HumanResourcesDepartmentAPP\hrdApp\hrdApp\hrdApp\logo.ico
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"
Name: "ukrainian"; MessagesFile: "compiler:Languages\Ukrainian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked
Name: "quicklaunchicon"; Description: "{cm:CreateQuickLaunchIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked; OnlyBelowVersion: 0,6.1

[Files]
Source: "E:\������� ������\������ � ����������\2021\���� (����)\HumanResourcesDepartmentAPP\hrdApp\hrdApp\hrdApp\bin\Release\hrdApp.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "E:\������� ������\������ � ����������\2021\���� (����)\HumanResourcesDepartmentAPP\hrdApp\hrdApp\hrdApp\bin\Release\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName} v.{#MyAppVersion}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon
Name: "{userappdata}\Microsoft\Internet Explorer\Quick Launch\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: quicklaunchicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

